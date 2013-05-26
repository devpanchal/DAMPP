using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAMP_Forms.Forms;
using DAMP_Forms.Business;
using System.Configuration;
using System.Security.Cryptography;

namespace DAMP_Forms
{
    public partial class Form1 : Form
    {
        #region "Variable Declaration"

        bLogin objbLogin = new bLogin();

        #endregion

        #region "Page Event"

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region "Button Event"

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;
            SetData();
            if (objbLogin.LoginAuthentication(txtPassword.Text.Trim()))
            {
                MainFrm frm1 = new MainFrm();
                this.Hide();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Login Fail !!!");
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region "Common Function"

        private void SetData()
        {
            try
            {
                objbLogin.user_id = txtUserID.Text.Trim();
                objbLogin.password = txtPassword.Text.Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool Validation()
        {
            try
            {
                if (txtUserID.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please enter User ID");
                    return false;
                }

                if (txtPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please enter Password");
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        #endregion



        ///// <summary>
        ///// Encrypts a given password and returns the encrypted data
        ///// as a base64 string.
        ///// </summary>
        ///// <param name="plainText">An unencrypted string that needs
        ///// to be secured.</param>
        ///// <returns>A base64 encoded string that represents the encrypted
        ///// binary data.
        ///// </returns>
        ///// <remarks>This solution is not really secure as we are
        ///// keeping strings in memory. If runtime protection is essential,
        ///// <see cref="SecureString"/> should be used.</remarks>
        ///// <exception cref="ArgumentNullException">If <paramref name="plainText"/>
        ///// is a null reference.</exception>
        //public string Encrypt(string plainText)
        //{
        //    if (plainText == null) throw new ArgumentNullException("plainText");

        //    //encrypt data
        //    var data = Encoding.Unicode.GetBytes(plainText);
        //    byte[] encrypted = ProtectedData.Protect(data, null, Scope);

        //    //return as base64 string
        //    return Convert.ToBase64String(encrypted);
        //}

        ///// <summary>
        ///// Decrypts a given string.
        ///// </summary>
        ///// <param name="cipher">A base64 encoded string that was created
        ///// through the <see cref="Encrypt(string)"/> or
        ///// <see cref="Encrypt(SecureString)"/> extension methods.</param>
        ///// <returns>The decrypted string.</returns>
        ///// <remarks>Keep in mind that the decrypted string remains in memory
        ///// and makes your application vulnerable per se. If runtime protection
        ///// is essential, <see cref="SecureString"/> should be used.</remarks>
        ///// <exception cref="ArgumentNullException">If <paramref name="cipher"/>
        ///// is a null reference.</exception>
        //public string Decrypt(string cipher)
        //{
        //    if (cipher == null) throw new ArgumentNullException("cipher");

        //    //parse base64 string
        //    byte[] data = Convert.FromBase64String(cipher);

        //    //decrypt data
        //    byte[] decrypted = ProtectedData.Unprotect(data, null, Scope);
        //    return Encoding.Unicode.GetString(decrypted);
        //}



        /// <summary>
        /// Decrypts the specified encryption key.
        /// </summary>
        /// <param name="encryptionKey">The encryption key.</param>
        /// <param name="cipherString">The cipher string.</param>
        /// <param name="useHashing">if set to <c>true</c> [use hashing].</param>
        /// <returns>
        ///  The decrypted string based on the key
        /// </returns>
        public static string Decrypt(string encryptionKey, string cipherString, bool useHashing)
        {
            byte[] keyArray;
            //get the byte code of the string

            byte[] toEncryptArray = Convert.FromBase64String(cipherString);

            System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();

            if (useHashing)
            {
                //if hashing was used get the hash code with regards to your key
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(encryptionKey));
                //release any resource held by the MD5CryptoServiceProvider

                hashmd5.Clear();
            }
            else
            {
                //if hashing was not implemented get the byte code of the key
                keyArray = UTF8Encoding.UTF8.GetBytes(encryptionKey);
            }

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)

            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //return the Clear decrypted TEXT
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        /// Encrypts the specified to encrypt.
        /// </summary>
        /// <param name="toEncrypt">To encrypt.</param>
        /// <param name="useHashing">if set to <c>true</c> [use hashing].</param>
        /// <returns>
        /// The encrypted string to be stored in the Database
        /// </returns>
        public static string Encrypt(string encryptionKey, string toEncrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();

            //If hashing use get hashcode regards to your key
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(encryptionKey));
                //Always release the resources and flush data
                // of the Cryptographic service provide. Best Practice

                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(encryptionKey);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)

            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //transform the specified region of bytes array to resultArray
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = Encrypt(txtPassword.Text.Trim(), txtPassword.Text.Trim(), true);

                string str2 = Decrypt(str, str, false);
            }
            catch
            {

            }
        }

       
    }
}
