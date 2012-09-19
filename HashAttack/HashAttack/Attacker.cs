using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Collections;

namespace HashAttack
{
    class Attacker
    {
        private Byte[] buffer1;
        private Byte[] buffer2;
        SHA1CryptoServiceProvider cryptoTransformSHA1;
        private Random rand;
        private StringBuilder builder;

        public Attacker()
        {
            cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            builder = new StringBuilder();
            rand = new Random();
        }

        private String GetHash(Byte[] inBuf, int numHashBytes)
        {
            Byte[] result = new Byte[numHashBytes];

            Array.Copy(cryptoTransformSHA1.ComputeHash(inBuf), result, numHashBytes);

            String hash = BitConverter.ToString(result).Replace("-", "");
            // substring is nice for half-byte increases in digest length
            //String hash = BitConverter.ToString(result).Replace("-", "").Substring(0, 5);

            return hash;
        }

        private String GetRandomString()
        {
            builder.Clear();
            Char a;
            int strLength = Convert.ToInt32(Math.Floor(40 * rand.NextDouble() + 60));    // random string length between 3 and 20
            //int strLength = 100;
            for (int i = 0; i < strLength; i++)
            {
                //a = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rand.NextDouble() + 48)));   // 26, 48 for alphabet characters only
                a = Convert.ToChar(Convert.ToInt32(Math.Floor(95 * rand.NextDouble() + 32)));   // originally chose 94, but tilde never showed up
                builder.Append(a);
            }
            return builder.ToString();
        }

        public String[] TestCollisionAttack()
        {
            Encoding enc = new ASCIIEncoding();
            Dictionary<String,String> hashDict = new Dictionary<String,String>();
            int numBytesHash = 3;

            String compStr = "";
            Byte[] byteBuf = null;
            String hash = "";
            String foundStr = "";
            Byte[] byteFound = null;
            String hashFound = "";

            Boolean cont = true;
            //Start timer and go
            DateTime timeStart = DateTime.Now;
            DateTime timeUp = timeStart.AddSeconds(60);
            DateTime timeCompleted = timeUp;
            int count = 0;

            while (cont && (DateTime.Now < timeUp))
            {
                count++;
                compStr = GetRandomString();
                byteBuf = enc.GetBytes(compStr);
                hash = GetHash(byteBuf, numBytesHash);

                if (hashDict.ContainsKey(hash))
                {
                    timeCompleted = DateTime.Now;
                    foundStr = (String)hashDict[hash];
                    break;
                }

                hashDict.Add(hash, compStr);
            }

            byteFound = enc.GetBytes(foundStr);
            hashFound = GetHash(byteFound, numBytesHash);

            String[] results = new String[5];
            results[0] = compStr + " Count; " + count;
            results[1] = foundStr;
            results[2] = hash;
            results[3] = hashFound;
            results[4] = (timeCompleted - timeStart).ToString();

            return results;
        }

        public String[] TestPreimageAttack(String inStr)
        {
            int numBytesHash = 3;

            Encoding enc = new ASCIIEncoding();
            Byte[] byteBuf1 = enc.GetBytes(inStr);
            String hash1 = GetHash(byteBuf1, numBytesHash);
            String compStr = "";
            Byte[] byteBuf2 = null;
            String hash2 = "";
            Boolean cont = true;
            //Start timer and go
            DateTime timeStart = DateTime.Now;
            DateTime timeUp = timeStart.AddSeconds(120);
            DateTime timeCompleted = timeUp;
            int count = 0;
            
            while (cont && (DateTime.Now < timeUp))
            {
                count++;
                compStr = GetRandomString();
                //compStr = "superman";
                byteBuf2 = enc.GetBytes(compStr);
                hash2 = GetHash(byteBuf2, numBytesHash);
                
                if (hash1.Equals(hash2))
                {
                    timeCompleted = DateTime.Now;
                    break;
                }
            }


            String[] results = new String[5];
            results[0] = inStr + " Count; " + count;
            results[1] = compStr;
            results[2] = hash1;
            results[3] = hash2;
            results[4] = (timeCompleted - timeStart).ToString();
            
            return results;
        }
    }
}
