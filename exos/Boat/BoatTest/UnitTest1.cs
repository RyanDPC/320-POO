namespace Boat
{
    [TestClass]
    public class BoatTest
    {
        [TestMethod]
        public void TestLoadContainer()
        {
            Fridge fridge = new Fridge();
            Radioactif radioactif = new Radioactif();
            Boat boat = new Boat();

            boat.LoadContainer(fridge);
            boat.LoadContainer(radioactif);

            Assert.IsNotNull(boat);
        }
    }
}