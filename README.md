# FormtasksCsOOPAbstractionAndInterface

Task-1:AccountCheck

Aşağıdakı metodları olan IAccount interface-i yaradırsınız:
-PasswordChecker() – parameter olaraq string şifrəni qəbul edir.
-ShowInfo()

Aşağıdakı member-lərdən ibarət User class-ı yaradırsınız və IAccount-u implement edirsiniz:
-FullName
-Email
-Password

PasswordChecker() – bu metod gələn string şifrə dəyərinin şərtlərini ödəyib ödəmədiyini yoxlayıb true/false qaytarır.
Şərtlər:
---şifrə minimum 8 karakterli olmalıdır.
---şifrədə ən az 1 böyük hərf olmalıdır.
---şifrədə ən az 1 kiçik hərf olmalıdır.
---şifrədə ən az 1 rəqəm olmalıdır.

ShowInfo() – bu metod console-a userin FullName və Email-ini yazdırır.

Qeyd: User class-ında IAccount interface-i implement edilir. User yarandığı zaman email və şifrə təyin edilməsi məcburidir. User-ə şifrə təyin edilərkən şifrənin PasswordChecker() metodunun şərtlərini ödəməsi vacibdir.




Task-2: Animals

Animal class
-Name
-Gender-Age

Horse: Animal
-Sort

Sheep: Animal
-Type

Farm
-AddAnimal() – animal qəbul edib massivə əlavə edərək massivi qaytarır
-GetAnimalsByName()
-GetAnimalsByAge()

Program-da yoxlanış aparmaq.




Task-3: EmployeeAndStudent

Instance almaq olmayan Person classı yaradılır və Name, Surname, Age propertyləri olur.

Persondan miras alan Employee classı olur. Employee classında
- SalaryOfHour (saatbaşı qazandığı maaş)
- WorkingHour (30 gün ərzində neçə saat işlədiyi)
- CalculateSalary() - Ümumi maaşı hesablayan method.
memberləri olur.
Name, Surname, Age, SalaryOfHour, WorkingHour məlumatlarını daxil etmədən işçi yaratmaq mümkün olmasın.
İşçinin günlük ortalama iş saatı 8 saatdan çox ola bilməz. Aylıq maaşı 250 manatdan az ola bilməz. İşçi 18 yaşın altındadırsa işləmə hüququ yoxdur.

Persondan miras alan Student classı verilir. Student classında
- IQRank (IQ imtahanının nəticəsi (100 bal üzərindən))
- LanguageRank (Dil imtahanının nəticəsi (100 bal üzərindən))
- ExamResult() - Şagirdin iki imtahanının nəticəsi 120dən azdırsa, o zaman sinifdə qaldığı mənasını bildirən methoddur.
Name, Surname, Age, IQRank, LanguageRank məlumatlarını daxil etmədən Student yaratmaq mümken olmasın.
Şagirdin yaşı 6dan az, 20dən çoxdursa o zaman şagirdin məlumatları daxil edilə bilməsin




Task-4: Vehicles2

IDrivable interface
-Drive(double km)

IVehicle interface 
-Brand
-Model
-Millage


Bicycle class

Car class
-CurrentFuel
-FuelForKm
