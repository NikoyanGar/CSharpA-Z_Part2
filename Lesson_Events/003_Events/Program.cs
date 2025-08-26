namespace _003_Events;
//Key points
//Each subscriber checks event data and may ignore the event.
//Publisher doesn’t know who’s listening → low coupling.
//Try it
//Add a FraudService that reacts only if Name looks suspicious.
//Temporarily unsubscribe CrmService and register a user.
class Program
{
    static void Main()
    {
        var service = new UserService();

        // subscribe multiple handlers
        service.UserRegistered += EmailService.OnUserRegistered;
        service.UserRegistered += SmsService.OnUserRegistered;
        service.UserRegistered += BonusService.OnUserRegistered;
        service.UserRegistered += CrmService.OnUserRegistered;

        service.Register(new User { Name = "Anna", Email = "anna@x.com", ReferralCode = "REF42" });
        service.Register(new User { Name = "Bob", Phone = "+155512345" });
        service.Register(new User { Name = "Chris" }); // triggers only CRM
    }
}
