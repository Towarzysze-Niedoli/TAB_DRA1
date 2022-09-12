DELETE FROM CMS.dbo.Receptionists;
DELETE FROM CMS.dbo.Patients;
DELETE FROM CMS.dbo.LaboratoryTechnicians;
DELETE FROM CMS.dbo.LaboratoryManagers;
DELETE FROM CMS.dbo.Doctors;
DELETE FROM CMS.dbo.Admins;
DELETE FROM CMS.dbo.Addresses;
DELETE FROM CMS.dbo.ApplicationUsers;

-- Auto-generated SQL script #202205281712
INSERT INTO CMS.dbo.ApplicationUsers (Email,PhoneNumber,Password)
	VALUES (N'admin@system.com',N'123456789',N'10000$GxgFCBATUWXY4vnKWFOvkw69IkAywSsJ71bgZW96rc4X7kTB'); -- haslo: admin
INSERT INTO CMS.dbo.ApplicationUsers (Email,PhoneNumber,Password)
	VALUES (N'doctor@system.com',N'111222333',N'10000$Kz6q5TueIy3KhkqkDrLI2uU8Cw57wcF66nNp3DcJuDx52HVp'); -- haslo: password
INSERT INTO CMS.dbo.ApplicationUsers (Email,Password)
	VALUES (N'lm@system.com',N'10000$Kz6q5TueIy3KhkqkDrLI2uU8Cw57wcF66nNp3DcJuDx52HVp'); -- haslo: password
INSERT INTO CMS.dbo.ApplicationUsers (Email,Password)
	VALUES (N'lt@system.com',N'10000$Kz6q5TueIy3KhkqkDrLI2uU8Cw57wcF66nNp3DcJuDx52HVp'); -- haslo: password
INSERT INTO CMS.dbo.ApplicationUsers (Email,PhoneNumber,Password)
	VALUES (N'receptionist@system.com',N'222555888',N'10000$Kz6q5TueIy3KhkqkDrLI2uU8Cw57wcF66nNp3DcJuDx52HVp'); -- haslo: password


-- Auto-generated SQL script #202205281649
INSERT INTO CMS.dbo.Addresses (City,Street,HomeNumber,ZipCode)
	VALUES (N'Gliwice',N'Akademicka',N'16',N'44-100');
INSERT INTO CMS.dbo.Addresses (City,Street,HomeNumber,ZipCode)
	VALUES (N'Ruda Œl¹ska',N'1 Maja',N'1',N'41-706');
INSERT INTO CMS.dbo.Addresses (City,Street,HomeNumber,ZipCode)
	VALUES (N'Chorzów',N'Batorego',N'16',N'44-500');

-- Auto-generated SQL script #202205281645
INSERT INTO CMS.dbo.Admins (FirstName,LastName,Email,PhoneNumber)
	VALUES (N'System',N'Administrator',N'admin@system.com',N'123456789');

-- Auto-generated SQL script #202205281647
INSERT INTO CMS.dbo.Doctors (FirstName,LastName,Email,PhoneNumber,LicenseNumber)
	VALUES (N'Jan',N'Kowalski',N'doctor@system.com',N'111222333',N'1234567');

-- Auto-generated SQL script #202205281650
UPDATE CMS.dbo.Doctors
	SET Address_Id = (
		SELECT Id FROM CMS.dbo.Addresses ad WHERE ad.City = N'Gliwice' AND ad.Street = N'Akademicka'
	)
	WHERE Email = N'doctor@system.com';

-- Auto-generated SQL script #202205281654
INSERT INTO CMS.dbo.LaboratoryManagers (FirstName,LastName,Email)
	VALUES (N'Krzysztof',N'Nowak',N'lm@system.com');

-- Auto-generated SQL script #202205281654
INSERT INTO CMS.dbo.LaboratoryTechnicians (FirstName,LastName,Email)
	VALUES (N'Zdzis³aw',N'Wiœniewski ',N'lt@system.com');


-- Auto-generated SQL script #202205281656
INSERT INTO CMS.dbo.Patients (FirstName,LastName,PersonalIdentityNumber,Email,PhoneNumber,Address_Id)
	VALUES (N'Miros³aw',N'Wójcik ',N'00210199999',N'mwojcik@email.com',N'548965745',(
		SELECT Id FROM CMS.dbo.Addresses ad WHERE ad.City = N'Ruda Œl¹ska' AND ad.Street = N'1 Maja'
	));
INSERT INTO CMS.dbo.Patients (FirstName,LastName,PersonalIdentityNumber,Email,PhoneNumber,Address_Id)
	VALUES (N'Krystyna',N'Kowalczyk',N'00311588888',N'kkowalczyk@email.com',N'789456589',(
		SELECT Id FROM CMS.dbo.Addresses ad WHERE ad.City = N'Chorzów' AND ad.Street = N'Batorego'
	));

-- Auto-generated SQL script #202205281705
INSERT INTO CMS.dbo.Receptionists (FirstName,LastName,Email,PhoneNumber)
	VALUES (N'Barbara',N'Kamiñska',N'receptionist@system.com',N'222555888');




