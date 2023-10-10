using Core;
using System;
using Xunit;

namespace Tests
{
    public class LoginTestSuite
    {
        // Grundläggande tester:
        // 1. Kunna registrera ny användare & lösenord
        [Fact]
        public void UsernameAndPasswordRegistrationTestSuccess()
        {
            LoginManager loginManager = new LoginManager();

            Assert.True(loginManager.NewUserRegistered("theo1022", "Passw0rd!"));
        }

        [Theory]
        [InlineData("theo1022", "")]
        [InlineData("", "Passw0rd!")]
        public void UsernameAndPasswordRegistrationTestFail(string username, string password)
        {
            LoginManager loginManager = new LoginManager();

            Assert.False(loginManager.NewUserRegistered(username, password));
        }

        // 2.Kunna logga in med användare &lösenord
        [Fact]
        public void UserLoginTestSuccess()
        {
            LoginManager loginManager = new LoginManager();
            var username = "theo2022";
            var password = "Passw0rd!";
            loginManager.NewUserRegistered(username, password);

            Assert.True(loginManager.TryLogin(username, password));
        }

        [Fact]
        public void UserLoginTestFail()
        {
            LoginManager loginManager = new LoginManager();
            var username = "theo1022";
            loginManager.NewUserRegistered(username, "Passw0rd!");

            Assert.False(loginManager.TryLogin(username, "WrongPassword"));
        }

        // 3.Inte kunna registrera samma användare två gånger om
        // 4.Bara kunna registrera användarnamn med engelska bokstäver(a-z, A - Z) siffor(0 - 9) och specialtecken(-_) som är max 16 karaktärer långa
        // 5.Bara kunna registrera lösenord med bokstäver(a - z, A - Z) siffor(0 - 9) och specialtecken (!”#¤%&/()=?-_*’) som är max 16 karaktärer långa
        // 6.Bara kunna registrera lösenord med minst längd 8 och minst en siffra och ett specialtecken
        // 7.Spara ner användare &lösenord(t.ex.till en.txt fil) vid registrering
        // 8.Kolla nersparade användares lösenord vid inloggning
        // 9.Inaktivera användarens lösenord efter ett år. Tips: spara ner datumen tillsammans med lösenorden för att inte ”glömma bort”
    }
}
