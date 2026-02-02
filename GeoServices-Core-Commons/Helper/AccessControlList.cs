
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace GeoServices_Core_Commons.Helper
{
    public class AccessControlList
    {           

        private string AccessKeysFilePath { get; set; }
        private Regex KeyPattern { get; set; }

        public  HashSet<string> ActiveKeys { get; set; } 

        public AccessControlList() {
            AccessKeysFilePath = Directory.GetCurrentDirectory() + "/AccessKeys/AccessKeys.json";
            KeyPattern = new Regex("^[a-zA-Z0-9]{16}$");
            ActiveKeys = new HashSet<string>();
        }

        public bool Verify(string userKey) => KeyPattern.IsMatch(userKey) && ActiveKeys.Contains(userKey);

        public async Task<AccessControlList> ReadKeyFile(bool checkExistingKeys = false) {

            if (checkExistingKeys && ActiveKeys.Count > 0) return this;  
                
            using (StreamReader reader = new StreamReader(AccessKeysFilePath))
            {
                string accessKeysJson = await reader.ReadToEndAsync();
                var activeKeysList = JsonSerializer.Deserialize<List<string>>(accessKeysJson);
                ActiveKeys = new HashSet<string>(activeKeysList);
            }
            return this;
        }
        public async Task<AccessControlList> AddNewKey() {
            using (StreamWriter writer = new StreamWriter(AccessKeysFilePath, append: true))
            {
                ActiveKeys.Add(GenerateRandomKey());
                File.Delete(AccessKeysFilePath);
                await writer.WriteAsync( JsonSerializer.Serialize( ActiveKeys.ToList() ) );

            }
            return this;
        }

        public string GenerateRandomKey(string pattern = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", int size = 16) {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < size; i++)
                sb.Append(pattern[random.Next(pattern.Length)]);
            return sb.ToString();
        }
    }
}
