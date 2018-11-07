namespace RobbersLangTests
{
    using System;
    using System.Collections.Generic;
    using RobbersLang;
    using Xunit;

    public class Translator_Tests
    {
        [Theory]
        [InlineData("Mañana", "Momañoñanona")]
        [InlineData("Jag talar Rövarspråket!", "Jojagog totalolaror Rorövovarorsospoproråkoketot!")]
        [InlineData("I'm speaking Robber's language!", "I'mom sospopeakokinongog Rorobobboberor'sos lolanongoguagoge!")]
        [InlineData("Tre Kronor är världens bästa ishockeylag.", "Totrore Kokrorononoror äror vovärorloldodenonsos bobäsostota isoshohocockokeylolagog.")]
        [InlineData("Vår kung är coolare än er kung.", "Vovåror kokunongog äror cocoololarore änon eror kokunongog.")]
        public void It_can_translate_to_robbers_language(string input, string expectedTranslation)
        {
            var actual = new Translator().Encode(input);
            Assert.Equal(expectedTranslation, actual);
        }
        
        [Theory]
        [InlineData("RrrRRrrRRRrrrrt", "RrrRRrrRRRrrrrortot")]
        [InlineData("Rr", "Rorr")]
        [InlineData("Aoui", "Aoui")]
        [InlineData("A", "A")]
        [InlineData("Ab", "Abob")]
        [InlineData("Au", "Au")]
        [InlineData("Jag talar Rövarspråket!", "Jojagog totalolaror Rorövovarorsospoproråkoketot!")]
        [InlineData("I'm speaking Robber's language!", "I'mom sospopeakokinongog Rorobobboberor'sos lolanongoguagoge!")]
        [InlineData("Tre Kronor är världens bästa ishockeylag.", "Totrore Kokrorononoror äror vovärorloldodenonsos bobäsostota isoshohocockokeylolagog.")]
        [InlineData("Vår kung är coolare än er kung.", "Vovåror kokunongog äror cocoololarore änon eror kokunongog.")]
        public void It_can_translate_from_robbers_language(string expectedDecoded, string encoded)
        {
            var actual = new Translator().Decode(encoded);
            Assert.Equal(expectedDecoded, actual);
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