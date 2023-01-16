// <DataType.cs> 2023/01/16完了分

namespace AccountBook;  // ファイル全体の名前空間

// 日付を扱うクラス
public class Date
{
    // 内部で保持する日時値（時刻は常に0:00:00とする）
    public DateTime Value { get; private set; } = default;

    // 値の文字列表現（オーバーライド）
    public override string ToString()
    {
        // 内部の値を短い日付表記で返す
        return Value.ToShortDateString();
    }

    // デフォルトコンストラクター
    public Date()
    {
        // 何もしない（既定値が設定される）
    }

    // 日時を受け取るコンストラクター
    public Date(DateTime dt)
    {
        // 日付部分のみ取り出して設定する
        Value = dt.Date;
    }

    // 文字列を受け取るコンストラクタ―
    public Date(string str)
    {
        // 文字列から日時型に変換する（失敗したら例外）
        var dt = DateTime.Parse(str);
        // 日付部分のみ取り出して設定する
        Value = dt.Date;
    }

    // Date型からDateTime型への暗黙的キャスト演算子のオーバーロード
    public static implicit operator DateTime(Date d)
    {
        // 内部で保持する日時を返す
        return d.Value;
    }

    // DateTime型からDate型への明示的キャスト演算子のオーバーロード
    public static explicit operator Date(DateTime dt)
    {
        // 日時から新規日付を生成して返す
        return new Date(dt);
    }

    // Date型からstring型への暗黙的キャスト演算子のオーバーロード
    public static implicit operator string(Date d)
    {
        // 日付の文字列表現を返す
        return d.ToString();
    }

    // string型からDate型への暗黙的キャスト演算子のオーバーロード
    public static implicit operator Date(string str)
    {
        // 文字列から新規日付を生成して返す
        return new Date(str);
    }
}


// 金銭を扱う構造体
public struct Money
{
    // 内部で保持する十進型の数値（正の整数のみとする）
    public decimal Value { get; private set; } = default;

    // 値の文字列表現（オーバーライド）
    public override string ToString()
    {
        // 内部の値を通貨形式で返す
        return Value.ToString("c");
    }

    // デフォルトコンストラクター
    public Money()
    {
        // 何もしない（既定値が設定される）
    }

    // decimal型を受け取るコンストラクタ―
    public Money(decimal dc)
    {
        // 負の値の場合、0を設定して終わる
        if (dc < 0)
        {
            Value = 0;
            return;
        }
        // 精密な四捨五入をした整数を設定する
        Value = Math.Round(dc, MidpointRounding.AwayFromZero);
    }

    // string型を受け取るコンストラクタ―
    public Money(string str) : this(decimal.Parse(str))
    {
        // 文字列を十進型に変換したものを別のコンストラクタ―に渡す
    }

    // decimal型からMoney型への暗黙的キャスト演算子のオーバーロード
    public static implicit operator Money(decimal dc)
    {
        // 数値から新たな金銭を生成して返す
        return new Money(dc);
    }

    // Money型からdecimal型への暗黙的キャスト演算子のオーバーロード
    public static implicit operator decimal(Money m)
    {
        // 内部で保持する値を返す
        return m.Value;
    }

    // Money型からint型への暗黙的キャスト演算子のオーバーロード
    public static implicit operator int(Money m)
    {
        // 内部で保持する値を明示的にint型にキャストして返す
        return (int)m.Value;
    }

    // Money型からstring型への明示的キャスト演算子のオーバーロード
    public static explicit operator string(Money m)
    {
        // 内部で保持する値を通常の文字列変換を行って返す
        return m.Value.ToString();
    }
}

// １件の家計簿データを保持するTransactionレコード
public record Transaction(
    Date Date,              // 日付
    string Category,        // 分類
    string Name,            // 品名
    Money Amount,           // 金額
    string Remarks          // 備考
);
