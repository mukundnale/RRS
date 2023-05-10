using Railway_Reservation.Models;

namespace Railway_Reservation.Repository
{
    public interface IPayment
    {
        Task<List<Payment>> GetPayments();
        Task<Payment> GetPaymentById(int id);
        Task<Payment> MakePayment(Payment payment);
        Task<Payment> CheckPaymentStatus(string status);
        Task<Payment> CancelPayment(Payment payment);   
    }
}
