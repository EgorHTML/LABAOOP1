using System;

public class RationalNumber
{
    private int Numerator;
    private int Denominator;

    public RationalNumber(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Знаменатель не может быть равен нулю.");

        Numerator = numerator;
        Denominator = denominator;
        Normalize();
    }

    private void Normalize()
    {
        int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
        Numerator /= gcd;
        Denominator /= gcd;

        if (Denominator < 0)
        {
            Numerator = -Numerator;
            Denominator = -Denominator;
        }
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        int newNumerator = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
        int newDenominator = r1.Denominator * r2.Denominator;
        return new RationalNumber(newNumerator, newDenominator);
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return r1 + (-r2);
    }

    public static RationalNumber operator -(RationalNumber r)
    {
        return new RationalNumber(-r.Numerator, r.Denominator);
    }

    public static bool operator ==(RationalNumber r1, RationalNumber r2)
    {
        return r1.Numerator == r2.Numerator && r1.Denominator == r2.Denominator;
    }

    public static bool operator !=(RationalNumber r1, RationalNumber r2)
    {
        return !(r1 == r2);
    }

    public static bool operator <(RationalNumber r1, RationalNumber r2)
    {
        return r1.Numerator * r2.Denominator < r2.Numerator * r1.Denominator;
    }

    public static bool operator <=(RationalNumber r1, RationalNumber r2)
    {
        return r1 < r2 || r1 == r2;
    }

    public static bool operator >(RationalNumber r1, RationalNumber r2)
    {
        return !(r1 <= r2);
    }

    public static bool operator >=(RationalNumber r1, RationalNumber r2)
    {
        return !(r1 < r2);
    }

      public override bool Equals(object obj)
    {
        if (obj is RationalNumber other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Numerator, Denominator);
    }


    public override string ToString()
    {
        if (Denominator == 1)
            return $"{Numerator}"; 
        return $"{Numerator}/{Denominator}";
    }
}