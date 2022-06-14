using System;
namespace Badetidssystemet
{
    public class Kreds
    {
        public string id { get; set; }
        public string navn { get; set; }
        public string adresse { get; set; }

        public Kreds(string aId, string aNavn, string aAdresse)
        {
            id = aId;
            navn = aNavn;
            adresse = aAdresse;

        }

        public override string ToString()
        {
            return $"ID: {id} navn: {navn} adresse: {adresse}";
        }
    }
}
