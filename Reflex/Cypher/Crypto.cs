/*
 * Classe responsável por criptografar e descriptografar os dados do usuário
 * Temos nesta classe 4 tipos de criptografia, porém usaremos somente o RC2,
 * isto pode ser alterado ao invocar o segundo contrutor desta classe, escolhendo
 * qualquer outro dos demais tipos
 * O construtor padrão utiliza o AES(Rijndael)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

/*
 * Reflex / Cypher / Crypto
 * @author MRX
 * Version : 1.0.0
 */

namespace Cypher
{

    //Classes diversas de criptografia
    public enum CryptProvider
    {

        //Representa a classe base para implementações criptografia dos algoritmos simétricos Rijndael.
        Rijndael,

        // Representa a classe base para implementações do algoritmo RC2.
        RC2,

        // Representa a classe base para criptografia de dados padrões (DES - Data Encryption Standard).
        DES,

        // Representa a classe base (TripleDES - Triple Data Encryption Standard).
        TripleDES
    }

    public class Crypto
    {

        //Variveis diversas

        private string _key = string.Empty;
        private CryptProvider _cryptProvider;
        private SymmetricAlgorithm _algorithm;
       
        // Inicialização do vetor do algoritmo simétrico
        private void SetIV()
        {
            switch (_cryptProvider)
            {
                case CryptProvider.Rijndael:
                    _algorithm.IV = new byte[] { 0xf, 0x6f, 0x13, 0x2e, 0x35, 0xc2, 0xcd, 0xf9, 0x5, 0x46, 0x9c, 0xea, 0xa8, 0x4b, 0x73, 0xcc };
                    break;
                default:
                    _algorithm.IV = new byte[] { 0xf, 0x6f, 0x13, 0x2e, 0x35, 0xc2, 0xcd, 0xf9 };
                    break;
            }
        }
        

        // Chave secreta para o algoritmo simétrico de criptografia.
        
        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }
   
       
        // Contrutor padrão da classe, é setado um tipo de criptografia padrão (Rijndael).
   
        public Crypto()
        {
            _algorithm = new RijndaelManaged();
            _algorithm.Mode = CipherMode.CBC;
            _cryptProvider = CryptProvider.Rijndael;
        }
        
        // Construtor com o tipo de criptografia a ser usada Você pode escolher o tipo pelo Enum chamado CryptProvider.

        public Crypto(CryptProvider cryptProvider)
        {
            // Seleciona algoritmo simétrico
            switch (cryptProvider)
            {
                case CryptProvider.Rijndael:
                    _algorithm = new RijndaelManaged();
                    _cryptProvider = CryptProvider.Rijndael;
                    break;
                case CryptProvider.RC2:
                    _algorithm = new RC2CryptoServiceProvider();
                    _cryptProvider = CryptProvider.RC2;
                    break;
                case CryptProvider.DES:
                    _algorithm = new DESCryptoServiceProvider();
                    _cryptProvider = CryptProvider.DES;
                    break;
                case CryptProvider.TripleDES:
                    _algorithm = new TripleDESCryptoServiceProvider();
                    _cryptProvider = CryptProvider.TripleDES;
                    break;
            }
            _algorithm.Mode = CipherMode.CBC;
        }
        
        
      
        /// Gera a chave de criptografia válida dentro do array.
      
        public virtual byte[] GetKey()
        {
            string salt = string.Empty;
            // Ajusta o tamanho da chave se necessário e retorna uma chave válida
            if (_algorithm.LegalKeySizes.Length > 0)
            {
                // Tamanho das chaves em bits
                int keySize = _key.Length * 8;
                int minSize = _algorithm.LegalKeySizes[0].MinSize;
                int maxSize = _algorithm.LegalKeySizes[0].MaxSize;
                int skipSize = _algorithm.LegalKeySizes[0].SkipSize;
                if (keySize > maxSize)
                {
                    // Busca o valor máximo da chave
                    _key = _key.Substring(0, maxSize / 8);
                }
                else if (keySize < maxSize)
                {
                    // Seta um tamanho válido
                    int validSize = (keySize <= minSize) ? minSize : (keySize - keySize % skipSize) + skipSize;
                    if (keySize < validSize)
                    {
                        // Preenche a chave com arterisco para corrigir o tamanho
                        // _key = _key.PadRight(validSize / 8, "*");
                    }
                }
            }
            PasswordDeriveBytes key = new PasswordDeriveBytes(_key, ASCIIEncoding.ASCII.GetBytes(salt));
            return key.GetBytes(_key.Length);
        }
     
        // Encripta o dado solicitado.
      
        public virtual string Encrypt(string texto)
        {
            byte[] plainByte = Encoding.UTF8.GetBytes(texto);
            byte[] keyByte = GetKey();
            // Seta a chave privada
            _algorithm.Key = keyByte;
            SetIV();
            // Interface de criptografia / Cria objeto de criptografia
            ICryptoTransform cryptoTransform = _algorithm.CreateEncryptor();
            MemoryStream _memoryStream = new MemoryStream();
            CryptoStream _cryptoStream = new CryptoStream(_memoryStream, cryptoTransform, CryptoStreamMode.Write);
            // Grava os dados criptografados no MemoryStream
            _cryptoStream.Write(plainByte, 0, plainByte.Length);
            _cryptoStream.FlushFinalBlock();
            // Busca o tamanho dos bytes encriptados
            byte[] cryptoByte = _memoryStream.ToArray();
            // Converte para a base 64 string para uso posterior em um xml
            return Convert.ToBase64String(cryptoByte, 0, cryptoByte.GetLength(0));
        }

        // Desencripta o dado solicitado.

        public virtual string Decrypt(string textoCriptografado)
        {
            // Converte a base 64 string em num array de bytes
            byte[] cryptoByte = Convert.FromBase64String(textoCriptografado);
            byte[] keyByte = GetKey();
            // Seta a chave privada
            _algorithm.Key = keyByte;
            SetIV();
            // Interface de criptografia / Cria objeto de descriptografia
            ICryptoTransform cryptoTransform = _algorithm.CreateDecryptor();
            try
            {
                MemoryStream _memoryStream = new MemoryStream(cryptoByte, 0, cryptoByte.Length);
                CryptoStream _cryptoStream = new CryptoStream(_memoryStream, cryptoTransform, CryptoStreamMode.Read);
                // Busca resultado do CryptoStream
                StreamReader _streamReader = new StreamReader(_cryptoStream);
                return _streamReader.ReadToEnd();
            }
            catch
            {
                return null;
            }
        }

    }
}
