using FluentValidation;

namespace TWValidacao.Validators;

public static class CustomValidators
{
    public static IRuleBuilderOptions<T, TElement> AgeBetween<T, TElement>(
        this IRuleBuilderOptions<T, TElement> ruleBuilder,
        int max,
        int min = 0)
    {
        return ruleBuilder.Must(date =>
        {
            var age = calculateAge(Convert.ToDateTime(date));
            return age >= min && age <= max;
        });
    }

    private static int calculateAge(DateTime birthDate)
    {
        var today = DateTime.Today;
        var age = today.Year - birthDate.Year;
        if (birthDate.Date > today.AddYears(-age))
        {
            age--;
        }
        return age;
    }
}