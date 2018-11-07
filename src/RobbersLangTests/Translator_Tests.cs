namespace RobbersLangTests
{
    using System;
    using System.Collections.Generic;
    using RobbersLang;
    using Xunit;

    public class Translator_Tests
    {
        [Theory]
        [InlineData("Jag talar Rövarspråket!", "Jojagog totalolaror Rorövovarorsospoproråkoketot!")]
        [InlineData("I'm speaking Robber's language!", "I'mom sospopeakokinongog Rorobobboberor'sos lolanongoguagoge!")]
        [InlineData("Tre Kronor är världens bästa ishockeylag.", "Totrore Kokrorononoror äror vovärorloldodenonsos bobäsostota isoshohocockokeylolagog.")]
        [InlineData("Vår kung är coolare än er kung.", "Vovåror kokunongog äror cocoololarore änon eror kokunongog.")]
        public void It_can_translate_to_robbers_language(string input, string expectedTranslation)
        {
            var actual = new Translator().Encode(input);
            Assert.Equal(expectedTranslation, actual);
        }
        
        [Fact]
        public void It_handles_case_correctly()
        {
            var input = "Hi";
            var expectedTranslation = "Hohi";
            var actual = new Translator().Encode(input);

            Assert.Equal(expectedTranslation, actual);
        }
    }
}