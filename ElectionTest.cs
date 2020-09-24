using System;
using System.Collections.Generic;
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
            var candidates = new List<string>{"José"};
            var cpf = "000.000.000-00";
            // Quando / Ação
            var created = election.CreateCandidates(candidates, cpf, "incorrect");
            // Deve / Asserções
            Assert.Null(election.Candidates);
            Assert.False(created);
        }
        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            string candidate = "José";
            var candidates = new List<string>{candidate};
            var cpf = "111.111.111-11";
            // Quando / Ação
            // Estamos acessando o MÉTODO CreateCandidates do OBJETO election
            var created = election.CreateCandidates(candidates, cpf, "Pa$$w0rd");
            // Deve / Asserções
            Assert.True(created);
            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.Equal(1, election.Candidates.Count);
            Assert.Equal(candidate, election.Candidates[0].name);
        }
        [Fact]
        public void should_not_generate_same_id_for_both_candidates()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            string Jose = "José";
            string Ana = "Ana";
            var candidates = new List<string>{Jose, Ana};
            var cpf = "222.222.222-22";
            election.CreateCandidates(candidates, cpf, "Pa$$w0rd");
            // Quando / Ação
            var candidateJose = election.GetCandidatesByName(Jose);
            var candidateAna = election.GetCandidatesByName(Ana);
            // Deve / Asserções
            Assert.NotEqual(candidateAna, candidateJose);
        }
        [Fact]
        public void should_vote_twice_in_candidate_Fernando()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            string fernando = "Fernando";
            string ana = "Ana";
            var candidates = new List<string>{fernando, ana};
            var cpf = "333.333.333-33";
            election.CreateCandidates(candidates, cpf, "Pa$$w0rd");
            var fernandoId = election.GetCandidatesByName(fernando);
            var anaId = election.GetCandidatesByName(ana);
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(fernandoId, fernando);
            election.Vote(fernandoId, fernando);
            // Deve / Asserções
            var candidateFernando = election.Candidates.Find(x => x.id == fernandoId);
            var candidateAna = election.Candidates.Find(x => x.id == anaId);
            Assert.Equal(2, candidateFernando.votes);
            Assert.Equal(0, candidateAna.votes);
        }
        [Fact]
        public void should_return_Ana_as_winner_when_only_Ana_receives_votes()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            string fernando = "Fernando";
            string ana = "Ana";
            var candidates = new List<string>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var anaId = election.GetCandidatesByName(ana);
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            
            election.Vote(anaId);
            election.Vote(anaId);

            var winners = election.GetWinners();

            // Deve / Asserções
            
            Assert.Equal(1, winners.Count);
            Assert.Equal(anaId, winners[0].id);
            Assert.Equal(2, winners[0].votes);
        }



        [Fact]

        public void should_return_both_candidates_when_occurs_draw()
        {
            // Dado / Setup
            // OBJETO election

            var election = new Election();
            string fernando = "Fernando";
            string ana = "Ana";
            var candidates = new List<string>{fernando, ana};
            
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            var fernandoId = election.GetCandidatesByName(fernando);
            var anaId = election.GetCandidatesByName(ana);
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            
            election.Vote(anaId);
            election.Vote(fernandoId);
            var winners = election.GetWinners();
            
            // Deve / Asserções
            
            var candidateFernando = winners.Find(x => x.id == fernandoId);
            var candidateAna = winners.Find(x => x.id == anaId);
            Assert.Equal(1, candidateFernando.votes);
            Assert.Equal(1, candidateAna.votes);
        }
    }
}