using System;


namespace HashMaker

{
    // klass för information om password och dess olika hashar
    public class PasswordHashData
    {       
        public String Password { get; set; }
        public String HashSha256 { get; set; }
        public String HashSha384 { get; set; }
        public String HashSha512 { get; set; }
    }
}
