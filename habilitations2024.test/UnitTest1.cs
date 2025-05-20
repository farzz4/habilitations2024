using habilitations2024.dal;
using System.Linq;

namespace habilitations2024.test
{
    public class UnitTest1
    {
        [Fact]
        public void GetLesDeveloppeurs_RetourneListeNonVide()
        {
            // Arrange
            var access = new DeveloppeurAccess();

            // Act
            var result = access.GetLesDeveloppeurs();

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GetLesDeveloppeurs_ContientDeveloppeursSpecifiques()
        {
            // Arrange
            var access = new DeveloppeurAccess();
            int expectedMinCount = 1; // Au moins 1 développeur attendu

            // Act
            var result = access.GetLesDeveloppeurs();

            // Assert
            Assert.True(result.Count >= expectedMinCount);
        }
    }
}