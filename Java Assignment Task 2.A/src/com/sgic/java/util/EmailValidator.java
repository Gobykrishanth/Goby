package com.sgic.java.util;


//1. Write a method to validate the provided email address string (Pass email as String parameter),
 //return error message 'Email is Invalid' if email is not valid.

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class EmailValidator {
    public static String validateEmail(String email) {
        // Regular expression for email validation
        String emailRegex = "^[a-zA-Z0-9_+&*-]+(?:\\.[a-zA-Z0-9_+&*-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,7}$";
        if (email.matches(emailRegex)) {
            return null; // Email is valid
        } else {
            return "Email is Invalid";
        }
    }

    //    2. Write a method 'changeNullToString' which is receiving a String argument and
    //    if provided String argument null, replace it by empty.

    public static String changeNullToString(String Email_is_valid) {
        if (Email_is_valid == null) {
            return "";
        } else {
            return Email_is_valid;
        }
    }

    // 3. Write a method to convert Date in String to Date in format 'DD-MM-YYYY'
    public static Date convertStringToDate(String dateString) throws ParseException {
        DateFormat dateFormat = new SimpleDateFormat("DD-MM-YYYY");
        return dateFormat.parse(dateString);
    }


    //      4. Write a generic method to add two numbers given through parameter
    //      which can support for any numeric type arguments

    public static <T extends Number> T addNumbers(T num1, T num2) {
        if (num1 instanceof Integer) {
            return (T) Integer.valueOf(num1.intValue() + num2.intValue());
        } else if (num1 instanceof Double) {
            return (T) Double.valueOf(num1.doubleValue() + num2.doubleValue());
        } else if (num1 instanceof Float) {
            return (T) Float.valueOf(num1.floatValue() + num2.floatValue());
        } else if (num1 instanceof Long) {
            return (T) Long.valueOf(num1.longValue() + num2.longValue());
        } else if (num1 instanceof Short) {
            return (T) Short.valueOf((short) (num1.shortValue() + num2.shortValue()));
        } else if (num1 instanceof Byte) {
            return (T) Byte.valueOf((byte) (num1.byteValue() + num2.byteValue()));
        } else {
            throw new IllegalArgumentException("Unsupported number type");
        }
    }
}

