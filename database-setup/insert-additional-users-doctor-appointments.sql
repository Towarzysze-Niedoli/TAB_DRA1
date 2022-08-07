INSERT INTO CMS.dbo.Addresses
(Id, City, Street, HomeNumber, ZipCode)
VALUES(4, N'Ruda Śląska', N'1 Maja', N'2/5', N'41-706');
INSERT INTO CMS.dbo.Addresses
(Id, City, Street, HomeNumber, ZipCode)
VALUES(5, N'Chorzów', N'Dąbrowskiego', N'8a', N'41-500');
INSERT INTO CMS.dbo.Addresses
(Id, City, Street, HomeNumber, ZipCode)
VALUES(6, N'Gliwice', N'Akademicka', N'1', N'44-100');

INSERT INTO CMS.dbo.Patients
(Id, FirstName, LastName, PersonalIdentityNumber, Email, PhoneNumber, Address_Id)
VALUES(3, N'Jan', N'Pacjentowski', N'00292345889', NULL, NULL, 4);
INSERT INTO CMS.dbo.Patients
(Id, FirstName, LastName, PersonalIdentityNumber, Email, PhoneNumber, Address_Id)
VALUES(4, N'Irena', N'Nowak', N'78220788562', NULL, N'322429542', 5);
INSERT INTO CMS.dbo.Patients
(Id, FirstName, LastName, PersonalIdentityNumber, Email, PhoneNumber, Address_Id)
VALUES(5, N'Adam', N'Kowalski', N'92110458723', N'akowalski@aei.polsl.pl', NULL, 6);

INSERT INTO CMS.dbo.ApplicationUsers
(Id, Email, PhoneNumber, Password, IsDisabled)
VALUES(6, N'ebrzoza@system.com', NULL, N'10000$QfZnVo3yZc98COLKdO7BezAZP66Fs1new7r+lUgev2buhPfQ', 0); /* password1 */

INSERT INTO CMS.dbo.Doctors
(Id, FirstName, LastName, Email, PhoneNumber, Address_Id, LicenseNumber, Specialization)
VALUES(2, N'Ewa', N'Brzoza', N'ebrzoza@system.com', NULL, NULL, N'2627846', 1);

INSERT INTO CMS.dbo.Appointments
(Id, Description, Diagnosis, AppointmentStatus, RegistrationDate, CompletionDate, Doctor_Id, Patient_Id, Receptionist_Id, ScheduledDate)
VALUES(1, N'Pacjent skarży się na ból głowy i złe samopoczucie', N'Zwykłe przezibienie. Dostał L4, powinien odpoczywać przez najbliżyszy tydzień', 1, '2022-08-07 12:08:18.463', '2022-08-07 12:12:24.513', 1, 3, 1, '2022-08-13 08:00:00.000');
INSERT INTO CMS.dbo.Appointments
(Id, Description, Diagnosis, AppointmentStatus, RegistrationDate, CompletionDate, Doctor_Id, Patient_Id, Receptionist_Id, ScheduledDate)
VALUES(2, NULL, NULL, 0, '2022-08-07 12:08:50.263', NULL, 2, 2, 1, '2022-08-13 08:15:00.000');
INSERT INTO CMS.dbo.Appointments
(Id, Description, Diagnosis, AppointmentStatus, RegistrationDate, CompletionDate, Doctor_Id, Patient_Id, Receptionist_Id, ScheduledDate)
VALUES(3, NULL, NULL, 0, '2022-08-07 12:09:36.900', NULL, 1, 1, 1, '2022-09-30 14:27:00.000');
