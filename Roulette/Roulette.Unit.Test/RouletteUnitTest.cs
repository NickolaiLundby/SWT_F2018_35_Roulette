using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;

namespace Roulette.Unit.Test
{
	[TestFixture()]
	[Author("Gruppe 35")]
	public class RouletteUnitTest
	{
		//private RouletteGame _rouletteGame;
		private Roulette _uut;
		private IRandom _random;
		private IFieldFactory _fieldFactory;

		[SetUp]
		public void Setup()
		{
			_random = Substitute.For<IRandom>();
			_fieldFactory = Substitute.For<IFieldFactory>();
			_uut = new Roulette(_fieldFactory, _random);
		}

		[Test]
		public void Spin_Test()
		{
			_uut.Spin();
			_uut.Received().Spin();
		}


	}
}
