using Core;
using System;
using Xunit;

namespace Tests
{
    public class LoginTestSuite
    {
        [Fact]
        public void UsernameAndPasswordRegistrationTest()
        {
            LoginManager loginManager = new LoginManager();

            // Grundl�ggande tester:
            // 1. Kunna registrera ny anv�ndare & l�senord
            // 2.Kunna logga in med anv�ndare &l�senord
            // 3.Inte kunna registrera samma anv�ndare tv� g�nger om
            // 4.Bara kunna registrera anv�ndarnamn med engelska bokst�ver(a-z, A - Z) siffor(0 - 9) och specialtecken(-_) som �r max 16 karakt�rer l�nga
            // 5.Bara kunna registrera l�senord med bokst�ver(a - z, A - Z) siffor(0 - 9) och specialtecken (!�#�%&/()=?-_*�) som �r max 16 karakt�rer l�nga
            // 6.Bara kunna registrera l�senord med minst l�ngd 8 och minst en siffra och ett specialtecken
            // 7.Spara ner anv�ndare &l�senord(t.ex.till en.txt fil) vid registrering
            // 8.Kolla nersparade anv�ndares l�senord vid inloggning
            // 9.Inaktivera anv�ndarens l�senord efter ett �r. Tips: spara ner datumen tillsammans med l�senorden f�r att inte �gl�mma bort�
        }
    }
}
