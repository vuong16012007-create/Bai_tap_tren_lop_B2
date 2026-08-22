using System;

public class BankAccount
{
    // ==========================================
    // 1. Private Encapsulated State (Trạng thái nội bộ)
    // ==========================================
    private decimal _balance;
    private string _pin;
    private int _failedAttempts;

    // ==========================================
    // 2. Controlled Properties (Thuộc tính kiểm soát)
    // ==========================================
    
    // Read-only property: Chỉ có get, giá trị được gán 1 lần duy nhất trong Constructor
    public string AccountHolder { get; }

    // Public getter, private set: Bên ngoài chỉ được xem, bên trong Class mới được quyền đổi
    public bool IsLocked { get; private set; }

    // ==========================================
    // Constructor (Hàm tạo)
    // ==========================================
    public BankAccount(string accountHolder, string initialPin, decimal initialBalance = 0)
    {
        AccountHolder = accountHolder;
        _pin = initialPin;
        _balance = initialBalance;
        _failedAttempts = 0;
        IsLocked = false;
    }

    // ==========================================
    // 3. Encapsulated Methods & Business Logic (Logic nghiệp vụ)
    // ==========================================

    // Hàm gửi tiền
    public bool Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Lỗi: Số tiền gửi phải lớn hơn 0.");
            return false;
        }

        _balance += amount;
        Console.WriteLine($"Thành công: Đã nạp {amount:N0}đ. Số dư hiện tại: {_balance:N0}đ.");
        return true;
    }

    // Hàm rút tiền
    public bool Withdraw(decimal amount, string inputPin)
    {
        // 1. Kiểm tra tài khoản có bị khóa không
        if (IsLocked)
        {
            Console.WriteLine("Lỗi: Tài khoản đã bị khóa do nhập sai PIN quá nhiều lần.");
            return false;
        }

        // 2. Kiểm tra mã PIN
        if (inputPin != _pin)
        {
            _failedAttempts++;
            Console.WriteLine($"Lỗi: Sai mã PIN. (Số lần sai: {_failedAttempts}/3)");
            
            // Khóa tài khoản nếu sai từ 3 lần trở lên
            if (_failedAttempts >= 3)
            {
                IsLocked = true;
                Console.WriteLine("CẢNH BÁO: Tài khoản của bạn đã BỊ KHÓA!");
            }
            return false;
        }

        // Nếu nhập đúng PIN, reset lại số lần nhập sai về 0
        _failedAttempts = 0;

        // 3. Kiểm tra số tiền hợp lệ
        if (amount <= 0)
        {
            Console.WriteLine("Lỗi: Số tiền rút phải lớn hơn 0.");
            return false;
        }

        if (_balance < amount)
        {
            Console.WriteLine("Lỗi: Số dư không đủ để thực hiện giao dịch.");
            return false;
        }

        // 4. Trừ tiền
        _balance -= amount;
        Console.WriteLine($"Thành công: Đã rút {amount:N0}đ. Số dư còn lại: {_balance:N0}đ.");
        return true;
    }

    // Hàm xem số dư
    public decimal GetBalance(string inputPin)
    {
        if (IsLocked)
        {
            Console.WriteLine("Lỗi: Tài khoản đang bị khóa, không thể xem số dư.");
            return -1m; // Trả về -1m (kiểu decimal) để biểu thị lỗi
        }

        if (inputPin != _pin)
        {
            Console.WriteLine("Lỗi: Sai mã PIN. Không thể xem số dư.");
            return -1m;
        }

        return _balance;
    }

    // Hàm đổi mã PIN
    public bool ChangePin(string currentPin, string newPin)
    {
        if (IsLocked)
        {
            Console.WriteLine("Lỗi: Tài khoản đang bị khóa, không thể đổi PIN.");
            return false;
        }

        if (currentPin != _pin)
        {
            Console.WriteLine("Lỗi: Sai mã PIN hiện tại.");
            return false;
        }

        // Kiểm tra mã PIN mới: không rỗng, đúng 4 ký tự và phải là số
        if (string.IsNullOrEmpty(newPin) || newPin.Length != 4 || !int.TryParse(newPin, out _))
        {
            Console.WriteLine("Lỗi: Mã PIN mới không hợp lệ (Phải là 4 chữ số).");
            return false;
        }

        _pin = newPin;
        Console.WriteLine("Thành công: Đã đổi mã PIN mới.");
        return true;
    }
}

// ==========================================
// HÀM MAIN ĐỂ CHẠY THỬ CHƯƠNG TRÌNH
// ==========================================
public class Program
{
    public static void Main()
    {
        // 1. Tạo tài khoản với mã PIN ban đầu là "1234"
        BankAccount myAccount = new BankAccount("Nguyen Van A", "1234");
        Console.WriteLine($"Đã tạo tài khoản cho: {myAccount.AccountHolder}");

        // 2. Thử nạp tiền
        myAccount.Deposit(500000);

        // 3. Thử rút tiền với PIN sai 3 lần để test tính năng khóa tài khoản
        myAccount.Withdraw(100000, "0000"); // Sai lần 1
        myAccount.Withdraw(100000, "1111"); // Sai lần 2
        myAccount.Withdraw(100000, "2222"); // Sai lần 3 -> Bị khóa

        // 4. Thử rút tiền khi đã bị khóa
        myAccount.Withdraw(100000, "1234"); // Dù PIN đúng nhưng vẫn bị chặn

        // In ra màn hình kiểm tra trạng thái khóa
        Console.WriteLine($"Tài khoản có bị khóa không? {myAccount.IsLocked}");
    }
}