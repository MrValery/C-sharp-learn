// 1. Запросить ввести количество необходимой плитки в кв.м.

using System.Runtime.ConstrainedExecution;

Console.Write("Введите количество плитки в кв.м.: ");
uint tileQuantity = Convert.ToUInt32(Console.ReadLine());

// 2. Запросить ввести цену плитки за кв.м.

Console.Write("Введите цену плитки: ");
uint tilePrice = Convert.ToUInt32(Console.ReadLine());

// 3. Посчитать общую стоимость плитки.

decimal tileCost = tileQuantity * tilePrice;

// 4. Посчитать сумму скидки 10 %, если количество плики >= 100 кв.м.

bool discountAvailable = tileQuantity >= 100;

decimal discount = 0;

if (discountAvailable)
    {
    discount = tileCost / 100 * 10;
    }

decimal paymentAmount = tileCost - discount;

// 5. Вывести на экран общую стоимость, сумму скидки и сумму к оплате. 

Console.WriteLine($"Стоимость плитки: {tileCost} грн.");
Console.WriteLine($"Сумма скидки: {discount} грн.");
Console.WriteLine($"Сумма к оплате: {paymentAmount} грн.");

Console.ReadKey();