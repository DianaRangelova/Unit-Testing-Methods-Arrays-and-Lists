using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

[Test]
public void Test_MatrixAddition_ValidInput_ReturnsCorrectResult()
{
    // Arrange
    // Matrix 2x2 -> 2 rows, 2 columns
    List<List<int>> matrixA = new List<List<int>>()
        {
            new List<int>() { 1, 2 },
            new List<int>() { 3, 4 }
        };

    List<List<int>> matrixB = new List<List<int>>()
       {
            new List<int>() { 1, 1 },
            new List<int>() { 1, 1 },
        };

    List<List<int>> expectedMatrix = new List<List<int>>()
        {
            new List<int>() { 2, 3 },
            new List<int>() { 4, 5 },
        };

    // Act
    List<List<int>> actualMatrix = Matrix.MatrixAddition(matrixA, matrixB);

    // Assert
    Assert.That(actualMatrix, Is.EqualTo(expectedMatrix));
}

[Test]
public void Test_MatrixAddition_EmptyMatrices_ReturnsEmptyMatrix()
{
    // Arrange
    List<List<int>> matrixA = new List<List<int>>();
    List<List<int>> matrixB = new List<List<int>>();

    int expectedResultCount = 0;
    List<List<int>> expected = new List<List<int>>();

    // Act
    List<List<int>> actual = Matrix.MatrixAddition(matrixA, matrixB);

    // Assert
    Assert.AreEqual(expectedResultCount, actual);
    Assert.That(expected, Is.EqualTo(actual));
}

[Test]
public void Test_MatrixAddition_DifferentDimensions_DifferentLength_ThrowsArgumentException()
{
    // Arrange
    // Matrix 2x3 -> 2 rows, 3 columns
    List<List<int>> matrixA = new List<List<int>>()
        {
            new List<int>() { 1, 2, 3 },
            new List<int>() { 4, 5, 6 }
        };

    List<List<int>> matrixB = new List<List<int>>()
       {
            new List<int>() { 1, 2, 3 },
            new List<int>() { 4, 5, 6 },
            new List<int>() { 7, 8, 9 }
        };
    // Act + Assert
    Assert.Throws<ArgumentException>(code: () =>
    {
        Matrix.MatrixAddition(matrixA, matrixB);
    }, "Matrices must have the same dimensions for addition.");
}

[Test]
public void Test_MatrixAddition_DifferentDimensions_DifferentWidth_ThrowsArgumentException()
{
    // Arrange
    // Matrix 2x3 -> 3 rows, 2 columns
    List<List<int>> matrixA = new List<List<int>>()
        {
            new List<int>() { 1, 2 },
            new List<int>() { 3, 4 },
            new List<int>() { 5, 6 }
        };

    List<List<int>> matrixB = new List<List<int>>()
       {
            new List<int>() { 1, 2, 3 },
            new List<int>() { 4, 5, 6 },
            new List<int>() { 7, 8, 9 }
        };

    // Act + Assert
    Assert.Throws<ArgumentException>(code: () =>
    {
        Matrix.MatrixAddition(matrixA, matrixB);
    }, "Matrices must have the same dimensions for addition.");
}

[Test]
public void Test_MatrixAddition_NegativeNumbers_ReturnsCorrectResult()
{
    // Arrange
    // Matrix 2x2 -> 2 rows, 2 columns
    List<List<int>> matrixA = new List<List<int>>()
        {
            new List<int>() { 1, 2 },
            new List<int>() { 3, 4 }
        };

    List<List<int>> matrixB = new List<List<int>>()
       {
            new List<int>() { 0, -1 },
            new List<int>() { -3, -3 },
        };

    List<List<int>> expectedMatrix = new List<List<int>>()
        {
            new List<int>() { 1, 1 },
            new List<int>() { 0, 1 },
        };

    // Act
    List<List<int>> actualMatrix = Matrix.MatrixAddition(matrixA, matrixB);

    // Assert
    Assert.That(actualMatrix, Is.EqualTo(expectedMatrix));
}
public void Test_MatrixAddition_ZeroMatrix_ReturnsOriginalMatrix()
{
    // Arrange
    // Matrix 2x2 -> 2 rows, 2 columns
    List<List<int>> matrixA = new List<List<int>>()
        {
            new List<int>() { 1, 2 },
            new List<int>() { 3, 4 }
        };

    List<List<int>> matrixB = new List<List<int>>()
       {
            new List<int>() { 0, 0 },
            new List<int>() { 0, 0 },
        };

    // Act
    List<List<int>> actualMatrix = Matrix.MatrixAddition(matrixA, matrixB);

    // Assert
    Assert.That(actualMatrix, Is.EqualTo(matrixA));
}
