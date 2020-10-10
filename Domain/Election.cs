using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Election
    {
        // Propriedade abaixo:
        // Sempre em PascalCase
        private List<Candidate> _candidates { get; set; }
        public IReadOnlyCollection<Candidate> Candidates => _candidates;
        
        public Election()
        {
            _candidates = new List<Candidate>();
        }
        public bool CreateCandidates(List<Candidate> candidates, string password)
        {
            if (password == "Pa$$w0rd")
            {
                if (candidates == null)
                {
                    return true;
                }
                
                _candidates = candidates;

                return true;
            }
            else
            {
                return false;
            }
        }

        public Guid GetCandidateIdByCpf(string cpf)
        {
            return Candidates.FirstOrDefault(x => x.Cpf == cpf).Id;
        }
        public List<Guid> GetCandidatesIdByName(string name)
        {
            return Candidates.Where(x => x.Name == name).Select(N => N.Id).ToList();
        }
        public bool Vote(string cpf)
        {
            var candidate = _candidates.FirstOrDefault(x => x.Cpf == cpf);
            if (candidate == null)
            {
                return false;
            }

            candidate.Vote();
            return true;
        }
        public List<Candidate> GetWinners()
        {
            var winners = new List<Candidate>{_candidates[0]};
            for (int i = 1; i < Candidates.Count; i++)
            {
                if (_candidates[i].Votes > winners[0].Votes)
                {
                    winners.Clear();
                    winners.Add(_candidates[i]);
                }
                else if (_candidates[i].Votes == winners[0].Votes)
                {
                    winners.Add(_candidates[i]);
                }
            }
            return winners;
        }
    }    
}