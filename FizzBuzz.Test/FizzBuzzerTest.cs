﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Test
{
    [TestFixture]
    class FizzBuzzerTest
    {
        [Test]
        public void Get_Returns_1_for_1()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(1);

            Assert.That(result, Is.EqualTo("1"));
        }
        [Test]
        public void Get_Returns_2_for_2()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(2);

            Assert.That(result, Is.EqualTo("2"));
        }
        [Test]
        public void Get_Returns_Fizz_for_3()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void Get_Returns_Fizz_for_mull_3()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void Get_Returns_4_for_4()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(4);

            Assert.That(result, Is.EqualTo("4"));
        }
        [Test]
        public void Get_Returns_Buzz_for_5()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(10);

            Assert.That(result, Is.EqualTo("Buzz"));
        }
        [Test]
        public void Get_Returns_Buzz_for_10()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(10);

            Assert.That(result, Is.EqualTo("Buzz"));

        }
        [Test]
        public void Get_Returns_Buzz_for_15()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

    }
}
        

