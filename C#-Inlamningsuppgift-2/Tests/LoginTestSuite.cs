using Core;
using System;
using Xunit;

namespace Tests
{
    public class LoginTestSuite
    {
        private const string correctUsername = "theo1022";
        private const string correctPassword = "Passw0rd!";

        // Grundl�ggande tester:
        // 1. Kunna registrera ny anv�ndare & l�senord
        [Fact]
        public void UsernameAndPasswordRegistrationTestSuccess()
        {
            LoginManager loginManager = new LoginManager();

            Assert.True(loginManager.NewUserRegistered(correctUsername, correctPassword));
        }

        [Theory]
        [InlineData(correctUsername, "")]
        [InlineData("", correctPassword)]
        public void UsernameAndPasswordRegistrationTestFail(string username, string password)
        {
            LoginManager loginManager = new LoginManager();

            Assert.False(loginManager.NewUserRegistered(username, password));
        }

        // 2.Kunna logga in med anv�ndare & l�senord
        [Fact]
        public void UserLoginTestSuccess()
        {
            LoginManager loginManager = new LoginManager();
            loginManager.NewUserRegistered(correctUsername, correctPassword);

            Assert.True(loginManager.TryLogin(correctUsername, correctPassword));
        }

        [Fact]
        public void UserLoginTestFail()
        {
            LoginManager loginManager = new LoginManager();
            loginManager.NewUserRegistered(correctUsername, correctPassword);

            Assert.False(loginManager.TryLogin(correctUsername, "WrongPassword"));
        }

        // 3.Inte kunna registrera samma anv�ndare tv� g�nger om
        // 4.Bara kunna registrera anv�ndarnamn med engelska bokst�ver(a-z, A - Z) siffor(0 - 9) och specialtecken(-_) som �r max 16 karakt�rer l�nga
        // 5.Bara kunna registrera l�senord med bokst�ver(a - z, A - Z) siffor(0 - 9) och specialtecken (!�#�%&/()=?-_*�) som �r max 16 karakt�rer l�nga
        // 6.Bara kunna registrera l�senord med minst l�ngd 8 och minst en siffra och ett specialtecken
        // 7.Spara ner anv�ndare &l�senord(t.ex.till en.txt fil) vid registrering
        // 8.Kolla nersparade anv�ndares l�senord vid inloggning
        // 9.Inaktivera anv�ndarens l�senord efter ett �r. Tips: spara ner datumen tillsammans med l�senorden f�r att inte �gl�mma bort�
    }
}
