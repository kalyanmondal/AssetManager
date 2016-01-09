using Microsoft.Win32;

namespace AssetManagement
{
    public static class RegManager
    {
        public static void createKey()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AssetManager");
            if (key != null)
            {
                if (key.ValueCount == 0)
                {
                    key.SetValue("AdminUserName", Encrypter.Encrypt("123456", true));
                    key.SetValue("AdminPassword", Encrypter.Encrypt("123456", true));
                    key.SetValue("data source", "");
                    key.SetValue("provider", Encrypter.Encrypt("Microsoft.ACE.OLEDB.12.0", true));
                    key.SetValue("backupdatetime", "");
                    key.Close();
                }
            }
        }

        public static string getKey(string keyToGet)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AssetManager");
            string val = null;
            if (key != null)
            {
                val = key.GetValue(keyToGet).ToString();
                key.Close();
            }
            return val;
        }

        public static void updateKey(string whichToUpdate, string whatToUpdate)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AssetManager");
            if (key != null)
            {
                key.SetValue(whichToUpdate, Encrypter.Encrypt(whatToUpdate, true), RegistryValueKind.String);
                key.Close();
            }
        }

        public static void deleteAllKey()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE");
            using (key)
            {
                if (key != null)
                {
                    key.DeleteSubKeyTree("AssetManager");
                }
            }
        }
    }
}