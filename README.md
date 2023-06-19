# CourierProject
The key stakeholders of the system are:

Admin: The administrator plays a central role in the system, responsible for managing users, defining roles and permissions, monitoring system activities, generating reports, and overseeing the overall functioning of the courier management process.

Sender: The sender refers to individuals or organizations who initiate courier requests. They can create new courier orders, input the sender and receiver details, specify the type of package, select the desired delivery service, and generate shipping labels. Senders can also track the status of their couriers and receive notifications regarding delivery updates.

Receiver: The receiver represents the intended recipient of the courier. They can view incoming couriers, track the progress of their deliveries, and provide electronic signatures upon receiving the packages. Additionally, receivers have the ability to communicate with the courier personnel or the sender through the system, ensuring effective coordination and resolution of any potential issues.

Courier: Couriers are responsible for physically delivering the packages from the sender to the receiver. Once assigned to a courier, they can access their assigned courier details, including sender and receiver information, delivery instructions, and any special handling requirements. Couriers can update the delivery status, capture proof of delivery through photographs or electronic signatures, and communicate with the sender or receiver if necessary.






Database: 

create table admin_(

adminCNIC varchar(100) primary key,
aname_ varchar(100),
aemail varchar(100),
aphoneno varchar(100),
aadress varchar(100),
apassword_ varchar(100),
agender varchar(100),
aage int,
imageadress varchar(100)

)



CREATE TABLE courier_ (


courierid INT PRIMARY KEY,
adminCNIC varchar(300),
receiverCNIC varchar(300),
senderCNIC varchar(300),
status varchar(300),
weight INT,
senddate date,
receivedate date,
constraint admincnic FOREIGN KEY (adminCNIC) REFERENCES admin_ (adminCNIC),
constraint receivercnic FOREIGN KEY (receiverCNIC) REFERENCES receiver_ (receiverCNIC),
constraint sendercnic FOREIGN KEY (senderCNIC) REFERENCES sender_ (senderCNIC)


)



create table sender_(

senderCNIC varchar(100) primary key,
sname_ varchar(100),
sgender varchar(100),
semail varchar(100),
sphoneno varchar(100),
sage int,
adminCNIC varchar(100),
saddress varchar(300),
FOREIGN KEY (adminCNIC) REFERENCES admin_ (adminCNIC)

);

create table receiver_(
receiverCNIC varchar(100) primary key,
rname_ varchar(100),
rage int,
rgender varchar(100),
remail varchar(100),
rphoneno varchar(100),
adminCNIC varchar(100),
radress varchar(300),
FOREIGN KEY (adminCNIC) REFERENCES admin_ (adminCNIC)
);
        
