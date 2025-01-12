using System;
using System.Globalization;
class Program {
    static void Main(string[] args) {
        int caseNumber = 1; // Only declare caseNumber once
        double percent = 0.00;  
        double amount = 0.00;
        // Set values based on the caseNumber
        if (caseNumber == 1) { percent = 75.53; amount = 98765.43; }
        if (caseNumber == 2) { percent = 26.41; amount = 12345.68; }
        if (caseNumber == 3) { percent = 0.00; amount = 0.00; }
        // Display the values
        Console.WriteLine($"Percent: {percent:0.00}%"); 
        Console.WriteLine($"Currency: {amount.ToString("C", new CultureInfo("en-US"))}");
    }
}