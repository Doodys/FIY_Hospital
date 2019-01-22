# FIY_Hospital
Project "Fix It Yourself Hospital - Management App"

Required functionalities:

- Employees roles: Admin, Nurse, Doctor
- Doctors have one of specializations (e.g. laryngologist) + PWD number
- Fully working login screen
- Defining user's role by login and password
- If role is Admin user has full access to every function (e.g. admin panel)
- Admin panel:
  - Add employee
  - Delete employee
  - Change employee's data
- Other panels (access granted for every other role):
  - Show list of employees
  - Show list of employees defined by role 
  - If role user is looking for list of employees where role == Doctor, then you can define list by specialization
  - Show shifts for whole month (NSP oh god)
    - Employee can have max 10 shifts per month
    - Employee can't work day by day (minimum one day off between shifts)
    - Max one Doctor's specialization during one shift
