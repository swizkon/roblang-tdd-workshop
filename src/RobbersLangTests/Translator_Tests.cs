namespace RobbersLangTests
{
    using System;
    using RobbersLang;
    using Xunit;

    public class Translator_Tests
    {
        [Theory]
        [InlineData("Jag talar Rövarspråket!", "Jojagog totalolaror Rorövovarorsospoproråkoketot!")]
        public void It_can_translate_to_robber(string input, string expectedTranslation)
        {
            var actual = new Translator().ToRobberish(input);
            Assert.Equal(expectedTranslation, actual);
        }
    }
}

/*


Input 2
I'm speaking Robber's language!
Output 2
I'mom sospopeakokinongog Rorobobboberor'sos lolanongoguagoge!
Challenge inputs
Input 1
Tre Kronor är världens bästa ishockeylag.
Input 2
Vår kung är coolare än er kung. 
*/