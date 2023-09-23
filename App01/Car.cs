namespace App01;

// 自動車クラス
public class Car
{
    // プロパティ
    
    // メーカー
    public string Make { get; set; }
    
    // 型番
    public string Model { get; set; }
    
    // 年式
    public int Year { get; set; }
    
    // コンストラクタ
    public Car()
    {
        Make = "Honda";
        Model = "Civic";
        Year = 2010;
    }
    
    // メソッド
    
    // 車の情報を表示する
    public void ShowDetails()
    {
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
    }
}