using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Away.Api.Misc.Crypto
{
    public static class EncryptionHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null)
                throw new ArgumentNullException("clave");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("El valor no puede ser un espacio vacio.", "clave");

            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null)
                throw new ArgumentNullException("clave");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("El valor no puede ser un espacio vacio.", "clave");
            if (storedHash.Length != 64)
                throw new ArgumentException("El largo del hash de la clave es inválido (espera 64 bytes).", "claveHash");
            if (storedSalt.Length != 128)
                throw new ArgumentException("El largo del salt de la clave es inválido (espera 128 bytes).", "claveHash");

            using (var hmac = new HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i])
                        return false;
                }
            }

            return true;
        }
    }
}
