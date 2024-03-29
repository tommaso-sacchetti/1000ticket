using System;
using NUnit.Framework;
using _1000ticket;

namespace Tests
{   
    [TestFixture]
    public class TestAbbonamento
    {
        private DateTime now;
        private Abbonamento _abbonamento;

        [SetUp]
        public void AbbonamentoSetUp()
        {
            now = DateTime.Now;
            _abbonamento = new Abbonamento(TipoAbbonamento.abbonamentoDue, "AB01", now, "cassa1");
        }

        [Test]
        public void TestConstructor()
        {
            Assert.That(_abbonamento.TipoTitolo, Is.EqualTo(TipoAbbonamento.abbonamentoDue));
            Assert.That(_abbonamento.IngressiTotali, Is.EqualTo(2));
            Assert.That(_abbonamento.IngressiRimanenti, Is.EqualTo(2));
            Assert.That(_abbonamento.OrarioUltimoAccesso, Is.EqualTo(null));
            Assert.That(_abbonamento.Id, Is.EqualTo("AB01"));
            Assert.That(_abbonamento.Prezzo, Is.EqualTo(10));
            Assert.That(_abbonamento.OrarioVendita, Is.EqualTo(now));
            Assert.That(_abbonamento.UsernameVenditore, Is.EqualTo("cassa1"));

        }

        [Test]
        public void TestSets()
        {
            DateTime time = DateTime.Now;
            int ingressi = _abbonamento.IngressiRimanenti - 1;
            _abbonamento.IngressiRimanenti = ingressi;
            _abbonamento.OrarioUltimoAccesso = time;
            Assert.That(_abbonamento.IngressiRimanenti, Is.EqualTo(ingressi));
            Assert.That(_abbonamento.OrarioUltimoAccesso, Is.EqualTo(time));

        }
    }
}