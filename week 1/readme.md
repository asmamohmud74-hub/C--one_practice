Waa kan dukumentigaaga cusub ee la midabka ahaa cutubbadii hore, kaas oo ku salaysan sawiradaada cusub ee ku saabsan xogta ardayda (Student Information):

---

# Discourse Chapter 3

## Overview

This practice demonstrates how to:

* Create and initialize string and integer variables to capture student details from input fields


* Parse numeric data types correctly using `int.Parse()`

* Concatenate multiple variables and string literals together into a single comprehensive output


* Display the final result using a Label control, clear text fields, and close the form programmatically



---

## 1. Creating Variables and Initializing Inputs

In this step, multiple variables are declared to store student information such as name, student ID, department, and semester. The `int.Parse()` method is used for numeric fields to ensure type conversion.

* `name` and `id` store textual user information.


* `dept` and `semester` capture departmental and semester records.



The following screenshot shows how the variables are declared and initialized in C#:

![Creating Variables](Screenshot 2026-09-24 093533.png)

## 2. Concatenating Student Information

In this step, the individual variables are combined using the `+` operator along with spacing to format the complete student record nicely.

The result is stored in the `full_student_info` variable.

The following screenshot shows the string concatenation process:

![String Concatenation](Screenshot 2026-09-24 093536.png)

## 3. Displaying Output, Clearing, and Closing

After the values are combined, the final text is assigned to the `.Text` property of a Label control to show it on the form. Additional utilities include clearing the textboxes and closing the window using `this.Close()`.

The following screenshots show how the output is displayed, how fields are cleared, and how the form closes:

![Display Output](Screenshot 2026-09-24 093539.png)
![Clearing Form Controls](Screenshot 2026-09-24 093548.png)
![Closing Form](Screenshot 2026-09-24 093552.png)