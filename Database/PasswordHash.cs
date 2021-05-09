using System;


namespace HashMaker.Database 
{
    // klass för databastabellen PasswordHash
    class PasswordHash
    {
        // kolumner i tabellen 
        public int Id { get; set; }
        public String Password { get; set; }
        public String HashSha256 { get; set; }
        public String HashSha384 { get; set; }
        public String HashSha512 { get; set; }
    }
}
