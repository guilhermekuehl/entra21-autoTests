using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace entra21_tests
{
    public class ElectionTest
    {
        [Fact]
        public void should_not_create_candidates_when_password_is_incorrect()
        {
            // Dado / Setup
            var election = new Election();
            (string name, string cpf) candidate = ("José",  "111.111.111-11");
            var candidates = new List<(string name, string cpf)>{candidate};
            
            // Quando / Ação
            var created = election.CreateCandidates(candidates, "incorrect");
            // Deve / Asserções
            Assert.Empty(election.Candidates);
            Assert.False(created);
        }
        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (string name, string cpf) candidate = ("José",  "111.111.111-11");
            var candidates = new List<(string name, string cpf)>{candidate};
            // Quando / Ação
            // Estamos acessando o MÉTODO CreateCandidates do OBJETO election
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");
            // Deve / Asserções
            Assert.True(created);
            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.Equal(1, election.Candidates.Count);
            Assert.Equal(candidate.name, election.Candidates.ElementAt(0).Name);
        }
        [Fact]
        public void should_not_generate_same_id_for_both_candidates()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (string name, string cpf) jose = ("José",  "111.111.111-11");
            (string name, string cpf) ana = ("Ana",  "222.222.222-22");
            var candidates = new List<(string name, string cpf)>{jose, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            // Quando / Ação
            var candidateJose = election.GetCandidatesIdByName(jose.name);
            var candidateAna = election.GetCandidatesIdByName(ana.name);
            // Deve / Asserções
            Assert.NotEqual(candidateAna, candidateJose);
        }
        [Fact]
        public void should_vote_twice_in_candidate_Fernando()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (string name, string cpf) fernando = ("Fernando",  "111.111.111-11");
            (string name, string cpf) ana = ("Ana",  "222.222.222-22");

            var candidates = new List<(string name, string cpf)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var fernandoId = election.GetCandidateIdByCpf(fernando.cpf);
            var anaId = election.GetCandidateIdByCpf(ana.cpf);
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(fernandoId);
            election.Vote(fernandoId);
            // Deve / Asserções
            var candidateFernando = election.Candidates.First(x => x.Id == fernandoId);
            var candidateAna = election.Candidates.First(x => x.Id == anaId);
            Assert.Equal(2, candidateFernando.Votes);
            Assert.Equal(0, candidateAna.Votes);
        }
        [Fact]
        public void should_return_Ana_as_winner_when_only_Ana_receives_votes()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (string name, string cpf) fernando = ("Fernando",  "111.111.111-11");
            (string name, string cpf) ana = ("Ana",  "222.222.222-22");
            var candidates = new List<(string name, string cpf)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var anaId = election.GetCandidateIdByCpf(ana.cpf);
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            
            election.Vote(anaId);
            election.Vote(anaId);

            var winners = election.GetWinners();

            // Deve / Asserções
            
            Assert.Equal(1, winners.Count);
            Assert.Equal(anaId, winners[0].Id);
            Assert.Equal(2, winners[0].Votes);
        }
        
        [Fact]
        public void should_return_both_candidates_when_occurs_draw()
        {
            // Dado / Setup
            // OBJETO election

            var election = new Election();
            (string name, string cpf) fernando = ("Fernando",  "111.111.111-11");
            (string name, string cpf) ana = ("Ana",  "222.222.222-22");
            var candidates = new List<(string name, string cpf)>{fernando, ana};
            
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            var fernandoId = election.GetCandidateIdByCpf(fernando.cpf);
            var anaId = election.GetCandidateIdByCpf(ana.cpf);
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            
            election.Vote(anaId);
            election.Vote(fernandoId);
            var winners = election.GetWinners();
            
            // Deve / Asserções
            
            var candidateFernando = winners.Find(x => x.Id == fernandoId);
            var candidateAna = winners.Find(x => x.Id == anaId);
            Assert.Equal(1, candidateFernando.Votes);
            Assert.Equal(1, candidateAna.Votes);
        }
    }
}