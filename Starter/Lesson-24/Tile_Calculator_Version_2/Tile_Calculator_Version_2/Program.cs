/*
Создать калькулятор для расчета стоимости кафельной плитки со скидками: 
- 20% покупателям, приобретающим от 500 до 999 кв.м. плитки 
- 50% покупателям, приобретающим от 1000 кв.м. плитки
*/

Console.Write("Введите количество плитки в кв.м.: ");
uint tileQuantity = Convert.ToUInt32(Console.ReadLine()); // кв.м.

Console.Write("Введите цену плитки в грн.: ");
uint tilePrice = Convert.ToUInt32(Console.ReadLine());  // грн.

decimal discount = 0;

bool discount20pctAvailable = tileQuantity >= 500 && tileQuantity < 1000;
bool discount50pctAvailable = tileQuantity >= 1000;

decimal tileCost = tileQuantity * tilePrice;

if (discount20pctAvailable)
{
    discount = tileCost / 100 * 20;
}
else if (discount50pctAvailable)
{
    discount = tileCost / 100 * 50;
}

decimal amountPayable = tileCost - discount;

Console.WriteLine($"Стоимость плитки: {tileCost} грн.");
Console.WriteLine($"Сумма скидки: {discount} грн.");
Console.WriteLine($"Сумма к оплате: {amountPayable} грн.");