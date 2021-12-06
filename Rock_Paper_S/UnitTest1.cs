using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace Rock_Paper_S
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Player1_has_Rock_Player2_has_Rock_Expected_Draw()
        {
            //arrange
            Tools player1 = Tools.Rock;
            Tools player2 = Tools.Rock;

            var sut = new game();
            //act
            var actuall = sut.Play(player1, player2);
            //assert
            var exoected = "Draw";
            Assert.AreEqual(exoected, actuall);
        }

        [Test]
        public void Player1_has_Rock_Player2_has_Paper_Expected_Player1_Loses()
        {
            //arrange
            Tools player1 = Tools.Rock;
            Tools player2 = Tools.Paper;

            var sut = new game();
            //act
            var actuall = sut.Play(player1, player2);
            //assert
            var exoected = "Player1 Loses";
            Assert.AreEqual(exoected, actuall);
        }

        [Test]
        public void Player1_has_Rock_Player2_has_Scissors_Expected_Player1_Wins()
        {
            //arrange
            Tools player1 = Tools.Rock;
            Tools player2 = Tools.Scissors;

            var sut = new game();
            //act
            var actuall = sut.Play(player1, player2);
            //assert
            var exoected = "Player1 Wins";
            Assert.AreEqual(exoected, actuall);
        }

        [Test]
        public void Player1_has_Paper_Player2_has_Rock_Expected_Player1_Wins()
        {
            //arrange
            Tools player1 = Tools.Paper;
            Tools player2 = Tools.Rock;

            var sut = new game();
            //act
            var actuall = sut.Play(player1, player2);
            //assert
            var exoected = "Player1 Wins";
            Assert.AreEqual(exoected, actuall);
        }

        [Test]
        public void Player1_has_Paper_Player2_has_Paper_Expected_Draw()
        {
            //arrange
            Tools player1 = Tools.Paper;
            Tools player2 = Tools.Paper;

            var sut = new game();
            //act
            var actuall = sut.Play(player1, player2);
            //assert
            var exoected = "Draw";
            Assert.AreEqual(exoected, actuall);
        }

        [Test]
        public void Player1_has_Paper_Player2_has_Scissors_Expected_Player1_Loses()
        {
            //arrange
            Tools player1 = Tools.Paper;
            Tools player2 = Tools.Scissors;

            var sut = new game();
            //act
            var actuall = sut.Play(player1, player2);
            //assert
            var exoected = "Player1 Loses";
            Assert.AreEqual(exoected, actuall);
        }


        [Test]
        public void Player1_has_Scissors_Player2_has_Rock_Expected_Player1_Loses()
        {
            //arrange
            Tools player1 = Tools.Scissors;
            Tools player2 = Tools.Rock;

            var sut = new game();
            //act
            var actuall = sut.Play(player1, player2);
            //assert
            var exoected = "Player1 Loses";
            Assert.AreEqual(exoected, actuall);
        }

        [Test]
        public void Player1_has_Scissors_Player2_has_Paper_Expected_Player1_Wins()
        {
            //arrange
            Tools player1 = Tools.Scissors;
            Tools player2 = Tools.Paper;

            var sut = new game();
            //act
            var actuall = sut.Play(player1, player2);
            //assert
            var exoected = "Player1 Wins";
            Assert.AreEqual(exoected, actuall);
        }

        [Test]
        public void Player1_has_Scissors_Player2_has_Scissors_Expected_Draw()
        {
            //arrange
            Tools player1 = Tools.Scissors;
            Tools player2 = Tools.Scissors;

            var sut = new game();
            //act
            var actuall = sut.Play(player1, player2);
            //assert
            var exoected = "Draw";
            Assert.AreEqual(exoected, actuall);
        }


        public class game
        {
            string player1Wins = "Player1 Wins";
            string player1Loses = "Player1 Loses";
            string results;
            public string Play(Tools player1, Tools player2)
            {
            
                if (player1 == player2)
                {
                    results = "Draw";
                   
                }
                else
                {
                    switch (player1)
                    {
                        case Tools.Rock:
                            if (player2 == Tools.Scissors)
                            {
                                results = player1Wins;
                            }
                            else if (player2 == Tools.Paper)
                            {
                                results = player1Loses;
                            }
                            break;
                        case Tools.Paper:
                            if (player2 == Tools.Scissors)
                            {
                                results = player1Loses;
                            }
                            else if (player2 == Tools.Rock)
                            {
                                results = player1Wins;
                            }
                            break;
                        case Tools.Scissors:
                            if (player2 == Tools.Rock)
                            {
                                results = player1Loses;
                            }
                            else if (player2 == Tools.Paper)
                            {
                                results = player1Wins;
                            }
                            break;
                    }
                }
                return results;
            }
        }

        public enum Tools
        {
          Rock ,
          Paper ,
          Scissors ,
        }
    }
}
