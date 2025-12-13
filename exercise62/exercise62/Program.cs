using exercise62.Models;

TechnicalInformation technicalInformation = new TechnicalInformation(1500, "Windows/mac");
DigitalProduct product = new DigitalProduct("Photoshop", 89.99, technicalInformation);
product.ShowDetails();
