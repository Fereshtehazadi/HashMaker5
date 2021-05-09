using System;


namespace HashMaker.Database 
{
    // klass för databastabellen ProcessingInfo
    class ProcessingInfo
    {
        // kolumner i tabellen 
        public int Id { get; set; }
        public String NextPassword { get; set; }
        public long NoOfProcessedPasswords { get; set; }
    }
}
