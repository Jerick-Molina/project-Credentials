﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace project_Credentials.App.Features.Utils;

public class Hasher : IHasher
{
    public string HashPassword(string password)
    {
        using (var sha256 = SHA256.Create())
        {
            byte[] value;
            UTF8Encoding encoder = new UTF8Encoding();

            value = sha256.ComputeHash(encoder.GetBytes(password));

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {

                builder.Append(value[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
    public bool PasswordAuthentication(string password, string hashed)
    {

        var hash = HashPassword(password);

        if (hash == hashed)
        {
            return true;
        }
        return false;
    }

}
