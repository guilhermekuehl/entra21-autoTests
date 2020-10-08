using System;

namespace Domain
{
    public class Candidate
    {
        
        public Candidate(string name, string cpf)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cpf = cpf;
            Votes = 0;    
        }
        public Candidate(Guid id, string name, string cpf, int vote)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Votes = vote;    
        }

        public Guid Id { get; set; }


        public string Name { get; set; }

        public string Cpf { get; set; }

        public int Votes { get; set; }
    }
}