using System;
using System.Collections.Generic;
using System.Linq;

namespace entra21_tests
{
    class Election
    {
        // Propriedade abaixo:
        // Sempre em PascalCase
        public List<(Guid id, string name, string cpf, int votes)> Candidates { get; set; }
        public bool CreateCandidates(List<string> candidateNames, string password, string cpf)
        {
            if (password == "Pa$$w0rd")
            {
                Candidates = candidateNames.Select(candidateName => {
                return (Guid.NewGuid(), candidateName, cpf, 0);
                }).ToList();
                return true;
            }
            else
            {
                return false;
            }
        }
        // ToDo: Criar método que retorne um Guid que represente o candidato pesquisado por cpf
        // ToDo: Este método deve retornar a lista de candidatos que tem o mesmo nome informado
        
        public Guid GetCandidateIdByCpf(string cpf)
        {
            return Candidates.Where(x => x.cpf == cpf).id;
        }
        public List<string> GetCandidateIdByName(string name)
        {
            var candidateIdByName = Candidates.First(x => x.name == name).id;
            Candidates = Candidates.Select(candidateWithSameNames => {
                return candidateWithSameNames[0].name == candidateWithSameNames[1].name
                    ? (candidateWithSameNames[0].name, candidateWithSameNames.name[1])
                    : candidateWithSameNames[0].name;
                    }).ToList();
        }
        public void Vote(Guid id)
        {
            Candidates = Candidates.Select(candidate => {
                return candidate.id == id
                    ? (candidate.id, candidate.name, candidate.cpf, candidate.votes + 1)
                    : candidate;
            }).ToList();
        }
        public List<(Guid id, string name, string cpf, int votes)> GetWinners()
        {
            var winners = new List<(Guid id, string name, string cpf, int votes)>{Candidates[0]};
            for (int i = 1; i < Candidates.Count; i++)
            {
                if (Candidates[i].votes > winners[0].votes)
                {
                    winners.Clear();
                    winners.Add(Candidates[i]);
                }
                else if (Candidates[i].votes == winners[0].votes)
                {
                    winners.Add(Candidates[i]);
                }
            }
            return winners;
        }
    }    
}