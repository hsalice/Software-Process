using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new SchoolContext(
                    serviceProvider.GetRequiredService<DbContextOptions<SchoolContext>>()))
                {
                    if (context.Courses.Any())
                    {
                        return;
                    }

                    context.Courses.AddRange(
                         new Courses
                         {
                             CourseCode = "D111",
                             CourseName = "Data Fundamentals",
                             Description = "Gain a broad operational knowledge of database design and administration. During your studies you'll design a relational database to meet organisational requirements; apply interaction design concepts to a user interface; and store and retrieve organisational data using query and reporting tools.",
                             Year = 1,
                             Semester = 1,
                             Prerequisite = "None",
                             Compulsory = "True",
                             Category = "Software Development"
                         },

                         new Courses
                         {
                             CourseCode = "I121",
                             CourseName = "Systems Analysis Fundamentals",
                             Description = "Learn the principles of systems analysis and systems requirements elicitation techniques. During your studies you'll analyse situations requiring problem solving; elicit and model user requirements using a variety of techniques; and construct accurate systems analysis documentation reflecting requirements.",
                             Year = 1,
                             Semester = 1,
                             Prerequisite = "None",
                             Compulsory = "True",
                             Category = "Information Management"
                         },

                         new Courses
                         {
                             CourseCode = "T111",
                             CourseName = "Computer Fundamentals",
                             Description = "Gain an understanding of computer hardware, operating systems and troubleshooting techniques.",
                             Year = 1,
                             Semester = 1,
                             Prerequisite = "None",
                             Compulsory = "True",
                             Category = "Technology"
                         },

                       new Courses
                       {
                           CourseCode = "I101",
                           CourseName = "Information Systems",
                           Description = "Gain an understanding of business systems and essential components of the ICT profession.",
                           Year = 1,
                           Semester = 1,
                           Prerequisite = "None",
                           Compulsory = "True",
                           Category = "Information Management"
                       },

                       new Courses
                       {
                           CourseCode = "D101",
                           CourseName = "Programming Fundamentals",
                           Description = "Learn the fundamentals of programming to develop quality software. During your studies you'll develop an application using an industry standard language, and debug, test and document a software application.",
                           Year = 1,
                           Semester = 2,
                           Prerequisite = "None",
                           Compulsory = "True",
                           Category = "Software Development"
                       },

                       new Courses
                       {
                           CourseCode = "T101",
                           CourseName = "Network Fundamentals",
                           Description = "Learn the fundamentals of computer networks as they currently exist in industry, so that you can configure, test and troubleshoot local area networks.",
                           Year = 1,
                           Semester = 2,
                           Prerequisite = "None",
                           Compulsory = "True",
                           Category = "Technology"
                       },

                         new Courses
                         {
                             CourseCode = "I111",
                             CourseName = "Web Fundamentals",
                             Description = "Learn the fundamentals of web development and how to produce a quality website. You'll employ UX design principles that meet organisational requirements and apply an industry standard approach.",
                             Year = 1,
                             Semester = 2,
                             Prerequisite = "None",
                             Compulsory = "True",
                             Category = "Information Management"
                         },

                       new Courses
                       {
                           CourseCode = "I102",
                           CourseName = "User Support",
                           Description = "Learn how to deliver organisational technical support based on best practice in IT service management. During your studies you'll apply a user needs analysis to identify organisational requirements; create, deliver and evaluate a training session; and develop technical documentation to a professional standard.",
                           Year = 1,
                           Semester = 2,
                           Prerequisite = "None",
                           Compulsory = "True",
                           Category = "Information Management"
                       },

                       new Courses
                       {
                           CourseCode = "D211",
                           CourseName = "Database Development",
                           Description = "Learn how to effectively design an information system for a complex business application.",
                           Year = 2,
                           Semester = 1,
                           Prerequisite = "D111",
                           Compulsory = "True",
                           Category = "Software Development"
                       },

                       new Courses
                       {
                           CourseCode = "I203",
                           CourseName = "Digital Multimedia",
                           Description = "Learn to apply principles and techniques relating to the application of digital multimedia technologies. During your studies you'll learn about digital images, video and audio; create and manipulate digital image, video and audio files according to a technical specification for distribution across the ICT infrastructure; and optimise digital multimedia for commonly used ICT mediums.",
                           Year = 2,
                           Semester = 1,
                           Prerequisite = "I101",
                           Compulsory = "False",
                           Category = "Information Management"
                       },

                         new Courses
                         {
                             CourseCode = "I211",
                             CourseName = "eCommerce Systems",
                             Description = "Learn about the principles and application of electronic commerce technologies. During your studies you'll implement an online commercial website for selling products, and implement user security and session management for the website.",
                             Year = 2,
                             Semester = 1,
                             Prerequisite = "I111",
                             Compulsory = "False",
                             Category = "Information Management"
                         },

                       new Courses
                       {
                           CourseCode = "D201",
                           CourseName = "Advanced Programming",
                           Description = "Learn standard algorithms required for business application programming. During your studies you'll design and construct small applications using a variety of algorithms; devise test plans to ensure quality software; and create system maintenance documentation.",
                           Year = 2,
                           Semester = 1,
                           Prerequisite = "D101",
                           Compulsory = "False",
                           Category = "Software Development"
                       },

                       new Courses
                       {
                           CourseCode = "T201",
                           CourseName = "Network Services",
                           Description = "Learn to implement key network services as used in modern LANs and to explain the network protocols that these services use. During your studies you'll implement and explain the operation of name resolution; implement automatic network configuration; implement and explain the operation of directory services; implement and explain the operation of a web proxy; implement automatic browser configuration when a web proxy is used; implement file sharing; and implement and explain the operation of a basic firewall.",
                           Year = 2,
                           Semester = 1,
                           Prerequisite = "T101",
                           Compulsory = "False",
                           Category = "Technology"
                       },

                       new Courses
                       {
                           CourseCode = "T205",
                           CourseName = "Networks - Cisco ITN",
                           Description = "Gain practical and technical networking knowledge that will assist you to build simple LANs, perform basic configurations for routers and switches, and implement IP addressing schemes.",
                           Year = 2,
                           Semester = 1,
                           Prerequisite = "None",
                           Compulsory = "False",
                           Category = "Technology"
                       },

                         new Courses
                         {
                             CourseCode = "T206",
                             CourseName = "Networks - Cisco RSE",
                             Description = "Gain practical and technical networking knowledge that will allow you to configure and troubleshoot routers, switches and resolve common issues with RIPv1, RIPng, single-area and multi-area OSPF, virtual LANs, and inter-VLAN routing in both IPv4 and IPv6 networks.",
                             Year = 2,
                             Semester = 1,
                             Prerequisite = "T205",
                             Compulsory = "False",
                             Category = "Technology"
                         },

                       new Courses
                       {
                           CourseCode = "I221",
                           CourseName = "Analysis & Design",
                           Description = "Create quality analysis and design documentation for a moderately complex system.",
                           Year = 2,
                           Semester = 2,
                           Prerequisite = "I121",
                           Compulsory = "True",
                           Category = "Information Management"
                       },

                       new Courses
                       {
                           CourseCode = "I202",
                           CourseName = "IT Project Management",
                           Description = "Gain an understanding of project management theory and practice as it relates to the ICT industry.",
                           Year = 2,
                           Semester = 2,
                           Prerequisite = "I102",
                           Compulsory = "True",
                           Category = "Information Management"
                       },

                       new Courses
                       {
                           CourseCode = "I213",
                           CourseName = "Dynamic Web Solutions",
                           Description = "Learn to create a dynamic web application utilising a variety of open-source technologies. During your studies you'll design and document a web application; secure critical business data within the web application; interface with a web-based database management system; and implement user security and session management.",
                           Year = 2,
                           Semester = 2,
                           Prerequisite = "I111",
                           Compulsory = "False",
                           Category = "Information Management"
                       },

                         new Courses
                         {
                             CourseCode = "D201",
                             CourseName = "Advanced Programming",
                             Description = "Learn standard algorithms required for business application programming. During your studies you'll design and construct small applications using a variety of algorithms; devise test plans to ensure quality software; and create system maintenance documentation.",
                             Year = 2,
                             Semester = 2,
                             Prerequisite = "D101",
                             Compulsory = "False",
                             Category = "Software Development"
                         },

                       new Courses
                       {
                           CourseCode = "D202",
                           CourseName = "Software Process & Planning",
                           Description = "Learn to create quality software applications utilising a modern development approach. During your studies you'll work as a team on an iterative development project; manage an individual development task; implement processes to ensure quality; and compare and select an appropriate development method for a given problem.",
                           Year = 2,
                           Semester = 2,
                           Prerequisite = "D201",
                           Compulsory = "False",
                           Category = "Software Development"
                       },

                       new Courses
                       {
                           CourseCode = "T205",
                           CourseName = "Networks - Cisco ITN",
                           Description = "Gain practical and technical networking knowledge that will assist you to build simple LANs, perform basic configurations for routers and switches, and implement IP addressing schemes.",
                           Year = 2,
                           Semester = 2,
                           Prerequisite = "None",
                           Compulsory = "False",
                           Category = "Technology"
                       },

                       new Courses
                       {
                           CourseCode = "T206",
                           CourseName = "Networks - Cisco RSE",
                           Description = "Gain practical and technical networking knowledge that will allow you to configure and troubleshoot routers, switches and resolve common issues with RIPv1, RIPng, single-area and multi-area OSPF, virtual LANs, and inter-VLAN routing in both IPv4 and IPv6 networks.",
                           Year = 2,
                           Semester = 2,
                           Prerequisite = "T205",
                           Compulsory = "False",
                           Category = "Technology"
                       },

                         new Courses
                         {
                             CourseCode = "T211",
                             CourseName = "System Security",
                             Description = "Learn to analyse and implement computer systems security, including operating systems, server applications and networks; and explain the fundamentals of computer forensics.",
                             Year = 2,
                             Semester = 2,
                             Prerequisite = "T111",
                             Compulsory = "False",
                             Category = "Technology"
                         },

                       new Courses
                       {
                           CourseCode = "I301",
                           CourseName = "Professional Practice",
                           Description = "Prepare for transition into the ICT profession. Source an industry project and produce appropriate documentation.",
                           Year = 3,
                           Semester = 1,
                           Prerequisite = "None",
                           Compulsory = "True",
                           Category = "Information Management"
                       },

                       new Courses
                       {
                           CourseCode = "I302",
                           CourseName = "Industry Project",
                           Description = "Undertake an industry-based project of a complex nature. During this experience you'll manage an ICT project for industry; produce original work and project deliverables; consider and apply professional work ethics; meet project timelines and goals; record and evaluate project work and progress; and present project outcomes to sponsors and academic supervisors.",
                           Year = 3,
                           Semester = 1,
                           Prerequisite = "I301",
                           Compulsory = "True",
                           Category = "Information Management"
                       },

                       new Courses
                       {
                           CourseCode = "I321",
                           CourseName = "Advanced Systems Analysis",
                           Description = "Learn to introduce tools and techniques used to assess feasibility and present a business case; to complete an analysis of a complex information system based on the recommendation from the feasibility phase.",
                           Year = 3,
                           Semester = 1,
                           Prerequisite = "I221",
                           Compulsory = "False",
                           Category = "Information Management"
                       },

                         new Courses
                         {
                             CourseCode = "D301",
                             CourseName = "Software Engineering",
                             Description = "Learn to design and construct quality software ready for distribution. During your studies you'll perform object-oriented design and programming with a high level of proficiency; secure applications so that they are ready for distribution; conduct effective and efficient inspections; evaluate software user interfaces for accessibility and usability; and design and implement comprehenstive test plans.",
                             Year = 3,
                             Semester = 1,
                             Prerequisite = "D201",
                             Compulsory = "False",
                             Category = "Software Development"
                         },

                       new Courses
                       {
                           CourseCode = "D311",
                           CourseName = "Advanced Database Concepts",
                           Description = "Learn to successfully design, create and administer a data warehouse using a server-based database management system.",
                           Year = 3,
                           Semester = 1,
                           Prerequisite = "D211",
                           Compulsory = "False",
                           Category = "Software Development"
                       },

                       new Courses
                       {
                           CourseCode = "T301",
                           CourseName = "Network Design",
                           Description = "Learn to recommend uses for thin and thick client architectures and to design a thin client architecture. During your studies you'll analyse and evaluate network designs, select an appropriate technology and design for a given situation, and justify your selection.",
                           Year = 3,
                           Semester = 1,
                           Prerequisite = "T201",
                           Compulsory = "False",
                           Category = "Technology"
                       },

                       new Courses
                       {
                           CourseCode = "T302",
                           CourseName = "CISCO Scaling and Connecting",
                           Description = "Gain practical and technical networking knowledge that will assist in designing, building and analysing networks and their protocols using advanced technologies.",
                           Year = 3,
                           Semester = 1,
                           Prerequisite = "T206",
                           Compulsory = "False",
                           Category = "Technology"
                       },

                         new Courses
                         {
                             CourseCode = "T311",
                             CourseName = "Systems Administration",
                             Description = "Learn to design and construct a complex multi-user client/server network. You'll gain skills needed to configure and integrate complex systems.",
                             Year = 3,
                             Semester = 1,
                             Prerequisite = "T211",
                             Compulsory = "False",
                             Category = "Technology"
                         },

                       new Courses
                       {
                           CourseCode = "I302",
                           CourseName = "Industry Project",
                           Description = "Undertake an industry-based project of a complex nature. During this experience you'll manage an ICT project for industry; produce original work and project deliverables; consider and apply professional work ethics; meet project timelines and goals; record and evaluate project work and progress; and present project outcomes to sponsors and academic supervisors.",
                           Year = 3,
                           Semester = 2,
                           Prerequisite = "I301",
                           Compulsory = "True",
                           Category = "Information Management"
                       },

                       new Courses
                       {
                           CourseCode = "I301",
                           CourseName = "Professional Practice",
                           Description = "Prepare for transition into the ICT profession. Source an industry project and produce appropriate documentation.",
                           Year = 3,
                           Semester = 2,
                           Prerequisite = "None",
                           Compulsory = "True",
                           Category = "Information Management"
                       },

                       new Courses
                       {
                           CourseCode = "T302",
                           CourseName = "CISCO Scaling and Connecting",
                           Description = "Gain practical and technical networking knowledge that will assist in designing, building and analysing networks and their protocols using advanced technologies.",
                           Year = 3,
                           Semester = 2,
                           Prerequisite = "T206",
                           Compulsory = "False",
                           Category = "Technology"
                       },

                         new Courses
                         {
                             CourseCode = "T311",
                             CourseName = "Systems Administration",
                             Description = "Learn to design and construct a complex multi-user client/server network. You'll gain skills needed to configure and integrate complex systems.",
                             Year = 3,
                             Semester = 2,
                             Prerequisite = "T211",
                             Compulsory = "False",
                             Category = "Technology"
                         },

                       new Courses
                       {
                           CourseCode = "I303",
                           CourseName = "Managerial Practice",
                           Description = "Learn to analyse and evaluate management practices as they relate to the ICT industry. During your studies you'll discuss and analyse key issues associated with managing and structuring the ICT capability within an organisation; recommend and design a quality management programme for an organisation; apply best practice human resource management techniques; and commentate on the relevant legislation and social responsibility issues as they relate to the ICT industry.",
                           Year = 3,
                           Semester = 2,
                           Prerequisite = "I202",
                           Compulsory = "False",
                           Category = "Information Management"
                       },

                       new Courses
                       {
                           CourseCode = "D303",
                           CourseName = "Java Mobile & Web",
                           Description = "Learn to develop a small, enterprise-level Java application that provides support for a mobile workforce. During your studies you'll construct Java Server Pages; design and construct a supporting application for a mobile device; create client-side Java applications; and interface with business data held in a legacy relational database system.",
                           Year = 3,
                           Semester = 2,
                           Prerequisite = "D101",
                           Compulsory = "False",
                           Category = "Software Development"
                       },

                       new Courses
                       {
                           CourseCode = "D311",
                           CourseName = "Advanced Database Concepts",
                           Description = "Learn to successfully design, create and administer a data warehouse using a server-based database management system.",
                           Year = 3,
                           Semester = 2,
                           Prerequisite = "D211",
                           Compulsory = "False",
                           Category = "Software Development"
                       }
                    );
                    context.SaveChanges();
                }
            }
        }
    }

