namespace MangaReader.Shared.Utils;

public class UtilsDate
{
    public static string GetDate(DateTime? date)
    {
        string result = "";
        if(date==null)
            return result;
        try
        {
            //DateTime parsedDate = DateTime.Parse(date);
            TimeSpan difference = (TimeSpan)(DateTime.Now - date);

            double differentYears = Math.Ceiling(difference.TotalDays / 365.25);
            double differentMonths = Math.Ceiling(difference.TotalDays / 30);
            double differentDays = Math.Ceiling(difference.TotalDays);
            double differentHours = Math.Ceiling(difference.TotalHours);
            double differentMinutes = Math.Ceiling(difference.TotalMinutes);

            if (differentDays <= 1)
            {
                if (differentMinutes < 60)
                {
                    if (differentMinutes < 2)
                    {
                        return "now";
                    }
                    else
                    {
                        result = $"{differentMinutes} minutes";
                    }
                }
                else
                {
                    if (differentHours == 1)
                    {
                        result = $"1 hour";
                    }
                    else
                    {
                        result = $"{differentHours} hours";
                    }
                }
            }
            else if (differentDays == 1)
            {
                result = "yesterday";
            }
            else
            {
                if (differentDays > 30)
                {
                    if (differentMonths > 12)
                    {
                        result = $"{differentYears} years";
                    }
                    else
                    {
                        result = $"{differentMonths} months";
                    }
                }
                else
                {
                    result = $"{differentDays} days";
                }
            }

            return result;
        }
        catch (Exception e)
        {
            return result;
        }
    }
}
