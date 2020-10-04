using System;
using System.Collections.Generic;

namespace entra21_tests
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

        public Candidate(Guid id, string name, string cpf, int votes)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Votes = votes;
        }

        public Guid Id { get; set; }


        public string Name { get; set; }

        public string Cpf { get; set; }

        public int Votes { get; set; }
    }
}