using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using CogesTest.Domain.Entities;

namespace CogesTest.DataAccess.Seeding;

[SuppressMessage("ReSharper", "StringLiteralTypo")]
internal static class SampleQuizzes
{
    internal static QuizDefinition BiologyQuiz =>
        new(new Guid("998E4DB2-DFF0-438B-9BEB-FCA4852F4DF2")) {
            Title = "Biology",
            Description = "This quiz will test your knowledge of biology",
            Questions = new List<QuizQuestionDefinition> {
                new(new Guid("AFAB9F8A-C82A-4C53-9984-69B9E8671DAA")) {
                    DisplayOrder = 1,
                    Content = "Which scientist is credited with the discovery of penicillin ?",
                    CorrectOptionId = new Guid("C8F7E9A2-DA5C-4D4B-BCB6-903844CA4D62"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("C8F7E9A2-DA5C-4D4B-BCB6-903844CA4D62")) { DisplayOrder = 1, Content = "Alexander Fleming" },
                        new(new Guid("B35AAE4E-BE46-47C9-90C6-AB1FA8A417D2")) { DisplayOrder = 2, Content = "Isaac Newton" },
                        new(new Guid("F38E8C65-1D2C-4A1A-9477-7F10E3C2A79E")) { DisplayOrder = 3, Content = "Charles Darwin" },
                        new(new Guid("DA6FD683-19AA-4C07-8742-81241DA99E55")) { DisplayOrder = 4, Content = "Louis Pasteur" },
                        new(new Guid("8B5F03B4-3296-4BFC-B2F6-92C8220A6D2A")) { DisplayOrder = 5, Content = "Gregor Mendel" },
                        new(new Guid("97E34A55-98F7-4EE6-909F-F19637AABAA9")) { DisplayOrder = 6, Content = "Marie Curie" }
                    }
                },
                new(new Guid("BC014299-51F4-40D2-9E4D-7CA728743D4B")) {
                    DisplayOrder = 2,
                    Content = "Which blood type is considered the universal donor ?",
                    CorrectOptionId = new Guid("E85397A3-3A41-4CE9-94A4-FBA18C00DD84"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("F14EF5D7-5182-4E15-B8D1-875C2B4A68CE")) { DisplayOrder = 1, Content = "A" },
                        new(new Guid("B63E6CEB-826F-418B-B9FF-F9A0233D5A84")) { DisplayOrder = 2, Content = "AB" },
                        new(new Guid("DCE5A0E9-7DBD-4EBB-B36C-1A4B1F84E965")) { DisplayOrder = 3, Content = "B" },
                        new(new Guid("6B8E703A-51B0-4D39-AEAC-1E8F4F83F048")) { DisplayOrder = 4, Content = "O" },
                        new(new Guid("E85397A3-3A41-4CE9-94A4-FBA18C00DD84")) { DisplayOrder = 5, Content = "O-negative" },
                        new(new Guid("C3A015CC-7C7D-4DF1-B252-0A4821A69A5D")) { DisplayOrder = 6, Content = "AB-negative" }
                    }
                },
                new(new Guid("B682CEC4-A888-43B9-AEEE-BF37A54F3B52")) {
                    DisplayOrder = 3,
                    Content = "Which of the following is the powerhouse of the cell ?",
                    CorrectOptionId = new Guid("CB4571A0-48FD-4BCD-96C6-F29A6DFFD8B2"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("DB239FF1-7BE4-4E0D-8D9E-07C330D7EB2A")) { DisplayOrder = 1, Content = "Nucleus" },
                        new(new Guid("CB4571A0-48FD-4BCD-96C6-F29A6DFFD8B2")) { DisplayOrder = 2, Content = "Mitochondria" },
                        new(new Guid("EE0A965B-CF7B-4A68-9063-9B58DE5BC3F5")) { DisplayOrder = 3, Content = "Golgi apparatus" },
                        new(new Guid("DE3F3966-92AE-4DE2-A532-CB4291EF5D0B")) { DisplayOrder = 4, Content = "Endoplasmic reticulum" },
                        new(new Guid("2F8E3E3C-74BC-4802-AEA3-86E8721E54CE")) { DisplayOrder = 5, Content = "Ribosomes" }
                    }
                },
                new(new Guid("A8A5272E-4A21-4AB6-978C-3AE3F4C68C44")) {
                    DisplayOrder = 4,
                    Content = "Which of the following is responsible for transmitting signals between neurons in the nervous system ?",
                    CorrectOptionId = new Guid("C52EB3D1-BFA1-4A7A-A85E-4E23C88FF5EB"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("F5F70E6F-8F96-4F66-BED3-FE3A13A0CB37")) { DisplayOrder = 1, Content = "Dendrites" },
                        new(new Guid("285F7D6C-4A79-4D39-A0B2-6510B79AF1A3")) { DisplayOrder = 2, Content = "Axons" },
                        new(new Guid("C52EB3D1-BFA1-4A7A-A85E-4E23C88FF5EB")) { DisplayOrder = 3, Content = "Synapses" },
                        new(new Guid("0C19D43F-CB15-4A83-9636-B28AEB3653B2")) { DisplayOrder = 4, Content = "Myelin sheath" },
                        new(new Guid("E3CCFDF5-79D3-439C-B788-AF5C05D69386")) { DisplayOrder = 5, Content = "Neurotransmitters" }
                    }
                },
                new(new Guid("D6A4A4B0-BC44-4579-B152-07F2F089E6A5")) {
                    DisplayOrder = 5,
                    Content = "What is the process by which plants convert sunlight into energy ?",
                    CorrectOptionId = new Guid("CBB83345-95E1-416A-BD8A-1E687297CFCD"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("6A832FCF-152B-4C16-BE56-61F7CB228C02")) { DisplayOrder = 1, Content = "Respiration" },
                        new(new Guid("FF844B50-521D-4F2F-9B20-69CCFCBC90A0")) { DisplayOrder = 2, Content = "Digestion" },
                        new(new Guid("A1B577D3-73C2-45FD-9BB0-34D0C73C622B")) { DisplayOrder = 3, Content = "Circulation" },
                        new(new Guid("EC2D244C-ED14-49D0-9B7D-6565156544C4")) { DisplayOrder = 4, Content = "Reproduction" },
                        new(new Guid("CBB83345-95E1-416A-BD8A-1E687297CFCD")) { DisplayOrder = 5, Content = "Photosynthesis" }
                    }
                },
                new(new Guid("A53B99C3-7076-4C92-A80D-679D50C7D718")) {
                    DisplayOrder = 6,
                    Content = "Which of the following is responsible for carrying oxygen in the bloodstream ?",
                    CorrectOptionId = new Guid("D84934F4-73D9-4D4F-A86F-89093D832EC0"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("0B75B7F9-343B-4980-9895-1676725370F9")) { DisplayOrder = 1, Content = "White blood cells" },
                        new(new Guid("36FF52AF-6287-4EF1-9744-087A6E0C64BC")) { DisplayOrder = 2, Content = "Platelets" },
                        new(new Guid("D84934F4-73D9-4D4F-A86F-89093D832EC0")) { DisplayOrder = 3, Content = "Red blood cells" },
                        new(new Guid("A6EFC54D-F740-49F4-875A-3DCE3D03AD9E")) { DisplayOrder = 4, Content = "Plasma" },
                        new(new Guid("D68C80C5-F46E-4BFD-A2BB-4598E1A8A0F9")) { DisplayOrder = 5, Content = "Hemoglobin" }
                    }
                },
                new(new Guid("D2ABE449-A949-48AB-A22D-75FBC83A53A4")) {
                    DisplayOrder = 7,
                    Content = "What is the smallest unit of life ?",
                    CorrectOptionId = new Guid("32B2B076-2A8D-421B-A997-021682D04C1F"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("4B1C3A6F-7E7C-41F2-9EB0-A271B1C850FA")) { DisplayOrder = 1, Content = "Atom" },
                        new(new Guid("AE4F0A48-A71B-471A-A18E-0A3D7F0C0382")) { DisplayOrder = 2, Content = "Molecule" },
                        new(new Guid("B194D46A-4A34-4DF7-AE07-764173F5A206")) { DisplayOrder = 3, Content = "Organism" },
                        new(new Guid("32B2B076-2A8D-421B-A997-021682D04C1F")) { DisplayOrder = 4, Content = "Cell" },
                        new(new Guid("3F80FE11-5BCE-440B-8474-B8B19F40920B")) { DisplayOrder = 5, Content = "Tissue" }
                    }
                }
            }
        };

    internal static QuizDefinition ChemistryQuiz =>
        new(new Guid("FF7BCB2C-BDB5-432C-A6E0-D77E8FEB5698")) {
            Title = "Chemistry",
            Description = "This quiz will test your knowledge of chemistry",
            Questions = new List<QuizQuestionDefinition> {
                new(new Guid("F7195A6D-963C-47E7-9B2B-8F80651A9827")) {
                    DisplayOrder = 1,
                    Content = "What is the chemical symbol for the element gold ?",
                    CorrectOptionId = new Guid("FA75F0A7-C91D-4D2B-B162-4CE16FFD8918"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("D5EB4C8F-3D88-4C7E-BB4F-4A32E8436A29")) { DisplayOrder = 1, Content = "Go" },
                        new(new Guid("FA75F0A7-C91D-4D2B-B162-4CE16FFD8918")) { DisplayOrder = 2, Content = "Au" },
                        new(new Guid("29D816A6-238D-45A0-BCE3-73B69E507C5E")) { DisplayOrder = 3, Content = "Gd" },
                        new(new Guid("13BE4C57-82E2-4E0E-A623-9E124D862013")) { DisplayOrder = 4, Content = "Gl" },
                        new(new Guid("D2E511D7-4B15-4B7D-A102-BC4A29B20F6C")) { DisplayOrder = 5, Content = "Ag" }
                    }
                },
                new(new Guid("C54E81C9-23B5-4A0A-943D-4D7D3A97E7EF")) {
                    DisplayOrder = 2,
                    Content = "Which of the following is a noble gas ?",
                    CorrectOptionId = new Guid("8F03F5A9-2EFB-4C5F-B8AD-67CCFBB9964A"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("9A9C77DF-065E-4923-BB35-8BACDEBB9F27")) { DisplayOrder = 1, Content = "Hydrogen" },
                        new(new Guid("4ACF2BB1-73C5-4CE7-85C2-7A890E4D2463")) { DisplayOrder = 2, Content = "Oxygen" },
                        new(new Guid("59F6DAE2-6AA9-408D-A03F-C393C013DD20")) { DisplayOrder = 3, Content = "Nitrogen" },
                        new(new Guid("8F03F5A9-2EFB-4C5F-B8AD-67CCFBB9964A")) { DisplayOrder = 4, Content = "Helium" },
                        new(new Guid("6C45B062-A9F6-4FA0-8131-879E76CEA44A")) { DisplayOrder = 5, Content = "Carbon" },
                        new(new Guid("2025E0E1-BC1C-4E9B-8755-9A7A83699DA0")) { DisplayOrder = 6, Content = "Fluorine" },
                        new(new Guid("F1107174-FF25-422F-A8D5-13D5F23E6CC8")) { DisplayOrder = 7, Content = "Sodium" }
                    }
                },
                new(new Guid("A9A03348-C9D6-4A7D-B2E3-8A4911279341")) {
                    DisplayOrder = 3,
                    Content = "What is the pH value of a neutral solution ?",
                    CorrectOptionId = new Guid("D7D600F0-2C24-4B38-8576-4B7A29FD4562"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("F7A6C0BB-51B6-4F9B-B8D7-B4A6F47EB960")) { DisplayOrder = 1, Content = "0" },
                        new(new Guid("D7D600F0-2C24-4B38-8576-4B7A29FD4562")) { DisplayOrder = 2, Content = "7" },
                        new(new Guid("AA46A65D-1C42-496A-892F-A8E8AA788F38")) { DisplayOrder = 3, Content = "10" },
                        new(new Guid("4D93FAF2-DA1C-4AF9-819B-3FFEEFA6D88A")) { DisplayOrder = 4, Content = "14" }
                    }
                },
                new(new Guid("18367439-B48E-4A6B-9EB7-5BE4BFB659FD")) {
                    DisplayOrder = 4,
                    Content = "Which gas is most abundant in Earth's atmosphere ?",
                    CorrectOptionId = new Guid("36614C6E-58F5-4FDE-9FAE-1497F8BC06D0"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("5F0B663C-75C6-4DC2-B4F5-0E9E0B6605B7")) { DisplayOrder = 1, Content = "Oxygen" },
                        new(new Guid("20A97D3F-6FAA-4F11-B7EE-672C9E5E2706")) { DisplayOrder = 2, Content = "Carbon dioxide" },
                        new(new Guid("CEECFF81-4B92-4F1C-BC85-7F5833E634DC")) { DisplayOrder = 3, Content = "Methane" },
                        new(new Guid("E9D59CDA-0D89-4423-9091-F85AD7C3C18C")) { DisplayOrder = 4, Content = "Hydrogen" },
                        new(new Guid("E1234465-0A8C-4EAC-89C4-0726A703EF64")) { DisplayOrder = 5, Content = "Helium" },
                        new(new Guid("BF03A8B3-125D-46B7-8B84-8C6CC59851E2")) { DisplayOrder = 6, Content = "Argon" },
                        new(new Guid("36614C6E-58F5-4FDE-9FAE-1497F8BC06D0")) { DisplayOrder = 7, Content = "Nitrogen" }
                    }
                }
            }
        };

    internal static QuizDefinition GeographyQuiz =>
        new(new Guid("5B04F492-8260-476B-A19C-56BBCCBCEBD2")) {
            Title = "Geography",
            Description = "This quiz will test your knowledge of geography",
            Questions = new List<QuizQuestionDefinition> {
                new(new Guid("C1C0C759-5D7B-47CE-AF47-48F4D6BC63E1")) {
                    DisplayOrder = 1,
                    Content = "Which continent is home to the Sahara Desert ?",
                    CorrectOptionId = new Guid("3E56A940-73B4-4E7D-8A84-FAA02A02C8F6"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("F65BDF7D-0DA5-4313-AF19-A7A1F4B0AE9D")) { DisplayOrder = 1, Content = "North America" },
                        new(new Guid("9B60A821-BF13-4B2D-B4A3-F1DC37B9D3DA")) { DisplayOrder = 2, Content = "Europe" },
                        new(new Guid("F30DE3A9-5DD0-4F4E-9FF1-23E6611BDEDD")) { DisplayOrder = 3, Content = "South America" },
                        new(new Guid("7494F394-7A25-4A59-94E9-40F6EE54169F")) { DisplayOrder = 4, Content = "Asia" },
                        new(new Guid("3E56A940-73B4-4E7D-8A84-FAA02A02C8F6")) { DisplayOrder = 5, Content = "Africa" }
                    }
                },
                new(new Guid("7A8C98F1-1769-4C81-8AC1-98A2089FA5AB")) {
                    DisplayOrder = 2,
                    Content = "What is the capital city of Australia ?",
                    CorrectOptionId = new Guid("33A1AA6B-3E4B-4553-8329-9C692CAAB2B4"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("ED11E100-2EF9-4E86-B02C-1334DFB5F2D6")) { DisplayOrder = 1, Content = "Melbourne" },
                        new(new Guid("BE4D99B2-FCDB-4E76-83A2-0ED9745739F2")) { DisplayOrder = 2, Content = "Sydney" },
                        new(new Guid("A33424DE-7087-4E6B-BD8C-15E2A7B9A062")) { DisplayOrder = 3, Content = "Brisbane" },
                        new(new Guid("33A1AA6B-3E4B-4553-8329-9C692CAAB2B4")) { DisplayOrder = 4, Content = "Canberra" },
                        new(new Guid("33B5644A-8F1C-4015-8C8B-42DF327A41D6")) { DisplayOrder = 5, Content = "Perth" },
                        new(new Guid("ABBCFB44-DA7D-4A9C-8232-C1391D6E502A")) { DisplayOrder = 6, Content = "Adelaide" }
                    }
                },
                new(new Guid("ECDFFB44-5A72-43BB-9075-06DA10F7AA8C")) {
                    DisplayOrder = 3,
                    Content = "Which country is known as the \"Land of the Rising Sun\" ?",
                    CorrectOptionId = new Guid("26F69D84-DFB6-4B9E-8620-4397B03AA12A"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("8C2E34B5-1EFB-4DF2-88D3-6BBACE246951")) { DisplayOrder = 1, Content = "China" },
                        new(new Guid("A4B65C4B-843A-4A0C-A8B6-F99B77B671DA")) { DisplayOrder = 2, Content = "India" },
                        new(new Guid("26F69D84-DFB6-4B9E-8620-4397B03AA12A")) { DisplayOrder = 3, Content = "Japan" },
                        new(new Guid("ABD2E763-4E84-43E7-A2B9-C685F8EFB0F1")) { DisplayOrder = 4, Content = "South Korea" },
                        new(new Guid("4C85C78C-AC07-43DF-89E0-15A7A8FA9002")) { DisplayOrder = 5, Content = "Thailand" }
                    }
                },
                new(new Guid("35D6143B-825C-4380-85B9-76D0AAFA6D7A")) {
                    DisplayOrder = 4,
                    Content = "Which of the following is the longest river in the world?",
                    CorrectOptionId = new Guid("61708AC7-9C9F-4D66-A45B-ACE774B6796C"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("C0BE46C2-8B36-487F-84C2-FF8F40874107")) { DisplayOrder = 1, Content = "Amazon River" },
                        new(new Guid("61708AC7-9C9F-4D66-A45B-ACE774B6796C")) { DisplayOrder = 2, Content = "Nile River" },
                        new(new Guid("2C0194CD-307B-4863-9444-8DE0D2C0333E")) { DisplayOrder = 3, Content = "Mississippi River" },
                        new(new Guid("3A3AB92B-61C4-4287-95D9-0F28217958A7")) { DisplayOrder = 4, Content = "Yangtze River" },
                        new(new Guid("35DA2BB4-2445-4E49-B405-8C9E76C92A69")) { DisplayOrder = 5, Content = "Ganges River" },
                        new(new Guid("B6B6A65C-705D-4EF3-BB9B-5EFED10A0A09")) { DisplayOrder = 6, Content = "Indus River" }
                    }
                }
            }
        };

    internal static QuizDefinition MovieQuiz =>
        new(new Guid("5E27BE03-4757-4B4B-9055-F61DD4C2358A")) {
            Title = "Movies",
            Description = "This quiz will test your knowledge of movies",
            Questions = new List<QuizQuestionDefinition> {
                new(new Guid("5852F9B3-3BFD-45F3-A697-16067A8CA93C")) {
                    DisplayOrder = 1,
                    Content = "In which movie did Leonardo DiCaprio and Kate Winslet play the lead roles as Jack and Rose ?",
                    CorrectOptionId = new Guid("A4678578-7738-400E-9F29-022CE274B412"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("5852F9B3-3BFD-45F3-A697-16067A8CA93C")) { DisplayOrder = 1, Content = "The Hunt for Red October" },
                        new(new Guid("98B9386E-E811-488E-9151-664DF4D730A8")) { DisplayOrder = 2, Content = "The Abyss" },
                        new(new Guid("A4678578-7738-400E-9F29-022CE274B412")) { DisplayOrder = 3, Content = "Titanic" },
                        new(new Guid("0051A58C-63BC-4E5F-9836-66B0CE9945B4")) { DisplayOrder = 4, Content = "Sphere" }
                    }
                },
                new(new Guid("DF58AFC6-0D8A-4486-AB44-D5562EAC6E05")) {
                    DisplayOrder = 2,
                    Content = "Who played the character of Iron Man/Tony Stark in the Marvel Cinematic Universe ?",
                    CorrectOptionId = new Guid("97830EDD-145E-496E-91FD-9AFCBF9AB688"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("FBA7B29B-D262-485D-B3AE-1578E88848A3")) { DisplayOrder = 1, Content = "Chris Hemsworth" },
                        new(new Guid("AA977B67-6125-4FF6-930F-F2D565F795AD")) { DisplayOrder = 2, Content = "Chris Evans" },
                        new(new Guid("C565ABA1-5C28-495F-B560-A1E94C3B76E7")) { DisplayOrder = 3, Content = "Mark Ruffalo" },
                        new(new Guid("97830EDD-145E-496E-91FD-9AFCBF9AB688")) { DisplayOrder = 4, Content = "Robert Downey Jr." },
                        new(new Guid("FDE954A7-1A2F-44BE-9B5D-71AE99AE8DE2")) { DisplayOrder = 5, Content = "Tom Hiddleston" },
                        new(new Guid("80C4A024-D26E-42AC-9B86-23A8BA31FA79")) { DisplayOrder = 6, Content = "Tom Cruise" }
                    }
                },
                new(new Guid("0F6AF04C-6EAC-4C44-A267-CE2D89DBC8E3")) {
                    DisplayOrder = 3,
                    Content = "Which film features the character Hannibal Lecter ?",
                    CorrectOptionId = new Guid("DF2F14D5-6AF6-4DBE-9DB9-5081D5D18F72"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("2A835E99-155D-423C-9549-50521BD76520")) { DisplayOrder = 1, Content = "The Shining" },
                        new(new Guid("D1B51E76-4E62-417B-AD8A-037790A98CD3")) { DisplayOrder = 2, Content = "American Psycho" },
                        new(new Guid("03952B0E-9B88-43F6-9EDE-25C961346C26")) { DisplayOrder = 3, Content = "Content" },
                        new(new Guid("C9B8276F-4D93-44F3-8850-67A63344338D")) { DisplayOrder = 4, Content = "Prisoners" },
                        new(new Guid("DF2F14D5-6AF6-4DBE-9DB9-5081D5D18F72")) { DisplayOrder = 5, Content = "The Silence of the Lambs" },
                        new(new Guid("ED956D90-5CC3-4024-B45E-C376195911DB")) { DisplayOrder = 6, Content = "The Exorcist" },
                        new(new Guid("D65B06C2-59F9-4BF6-B3AB-ED17E4E0793C")) { DisplayOrder = 7, Content = "Halloween" }
                    }
                },
                new(new Guid("6D27C37F-9C44-4E3C-91C6-1B58AABFED4F")) {
                    DisplayOrder = 4,
                    Content = "Who directed the movie \"The Dark Knight\"?",
                    CorrectOptionId = new Guid("F8E33E3B-3123-4D45-9C62-869AFD4B34A6"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("4E2C7151-A0BD-4DA7-8D26-66B6A0BDD593")) { DisplayOrder = 1, Content = "James Cameron" },
                        new(new Guid("F8E33E3B-3123-4D45-9C62-869AFD4B34A6")) { DisplayOrder = 2, Content = "Christopher Nolan" },
                        new(new Guid("3B3D2C9D-AF84-4F59-8E47-69532EAE8CC1")) { DisplayOrder = 3, Content = "Quentin Tarantino" },
                        new(new Guid("7F84BCEE-4136-49A4-8F86-182EA8DAA0D7")) { DisplayOrder = 4, Content = "Martin Scorsese" }
                    }
                },
                new(new Guid("823BB708-34BE-4F25-90BC-2D6CB1E7B85C")) {
                    DisplayOrder = 5,
                    Content = "Which actor portrayed the character James Bond in the movie \"Casino Royale\"?",
                    CorrectOptionId = new Guid("9E781605-803B-4642-8EDC-496D81DFA04C"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("5792E3B0-AC55-491B-AE6F-6E870FE6AA92")) { DisplayOrder = 1, Content = "Pierce Brosnan" },
                        new(new Guid("2B8F3E0D-0B60-4E07-BB5F-EDBCDAAB22A3")) { DisplayOrder = 2, Content = "Timothy Dalton" },
                        new(new Guid("457C136E-C7C2-429F-85C7-1FDDF9D0984E")) { DisplayOrder = 3, Content = "Sean Connery" },
                        new(new Guid("618D23E5-82F1-4DE0-84D0-A70CC134E2C4")) { DisplayOrder = 4, Content = "Roger Moore" },
                        new(new Guid("9E781605-803B-4642-8EDC-496D81DFA04C")) { DisplayOrder = 5, Content = "Daniel Craig" }
                    }
                },
                new(new Guid("72D40207-CB66-4016-9D70-7EC20A5C54EF")) {
                    DisplayOrder = 6,
                    Content = "In the film \"The Matrix,\" what color pill does Neo take?",
                    CorrectOptionId = new Guid("8D46DF5F-715A-4A77-A948-4C6E3A1E29A1"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("5B7B85B2-F6E7-4E67-977A-3DB9E5203130")) { DisplayOrder = 1, Content = "Green" },
                        new(new Guid("1C71D964-0C11-4D69-9E0F-86F3BCE6F86F")) { DisplayOrder = 2, Content = "Blue" },
                        new(new Guid("24AC129B-1AF0-43A3-B0D2-097AA2D99270")) { DisplayOrder = 3, Content = "Purple" },
                        new(new Guid("8D46DF5F-715A-4A77-A948-4C6E3A1E29A1")) { DisplayOrder = 4, Content = "Red" },
                        new(new Guid("5013987F-1F30-45DD-A1F3-8C3A90C76B5F")) { DisplayOrder = 5, Content = "Yellow" }
                    }
                }
            }
        };

    internal static QuizDefinition ScienceQuiz =>
        new(new Guid("D27FE16C-BD2C-44BE-B777-FB55880CA6D4")) {
            Title = "Science",
            Description = "This quiz will test your knowledge of science",
            Questions = new List<QuizQuestionDefinition> {
                new(new Guid("C1E2B3A4-D5F6-4C7D-8E9F-A0B1C2D3E4F5")) {
                    DisplayOrder = 1,
                    Content = "What is the chemical symbol for the element oxygen ?",
                    CorrectOptionId = new Guid("2A1B3C4D-E5F6-4C7D-8E9F-A0B1C2D3E4F5"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("F1E2D3C4-B5A6-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 1, Content = "Ox" },
                        new(new Guid("1A2B3C4D-E5F6-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 2, Content = "Oxg" },
                        new(new Guid("2A1B3C4D-E5F6-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 3, Content = "O" },
                        new(new Guid("3A1B2C4D-E5F6-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 4, Content = "Oxn" }
                    }
                },
                new(new Guid("D1C2B3A4-E5F6-4C7D-8E9F-A0B1C2D3E4F5")) {
                    DisplayOrder = 2,
                    Content = "Which planet is known as the \"Red Planet\" ?",
                    CorrectOptionId = new Guid("2B3C4D5E-F6A7-4C7D-8E9F-A0B1C2D3E4F5"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("CB50B42C-BBB6-44F8-97EB-22A56DEF309A")) { DisplayOrder = 1, Content = "Venus" },
                        new(new Guid("2B3C4D5E-F6A7-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 2, Content = "Mars" },
                        new(new Guid("3B2C4D5E-F6A7-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 3, Content = "Jupiter" },
                        new(new Guid("4B2C3D5E-F6A7-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 4, Content = "Mercury" },
                        new(new Guid("5B2C3D4E-F6A7-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 5, Content = "Saturn" }
                    }
                },
                new(new Guid("E1D2C3B4-A5F6-4C7D-8E9F-A0B1C2D3E4F5")) {
                    DisplayOrder = 3,
                    Content = "What is the largest organ in the human body ?",
                    CorrectOptionId = new Guid("D1E2F3C4-B5A6-4C7D-8E9F-A0B1C2D3E4F5"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("D1E2F3C4-B5A6-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 1, Content = "Skin" },
                        new(new Guid("2C3D4E5F-A6B7-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 2, Content = "Heart" },
                        new(new Guid("3C2D4E5F-A6B7-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 3, Content = "Brain" },
                        new(new Guid("4C2D3E5F-A6B7-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 4, Content = "Lungs" },
                        new(new Guid("5C2D3E4F-A6B7-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 5, Content = "Stomach" },
                        new(new Guid("6C2D3E4F-A6B7-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 6, Content = "Liver" }
                    }
                },
                new(new Guid("F1E2D3C4-B5A6-4C7D-8E9F-A0B1C2D3E4F5")) {
                    DisplayOrder = 4,
                    Content = "Who developed the theory of general relativity ?",
                    CorrectOptionId = new Guid("4D2E3F5A-6B7C-4C7D-8E9F-A0B1C2D3E4F5"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("E1F2D3C4-B5A6-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 1, Content = "Isaac Newton" },
                        new(new Guid("2D3E4F5A-6B7C-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 2, Content = "Nikola Tesla" },
                        new(new Guid("3D2E4F5A-6B7C-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 3, Content = "Marie Curie" },
                        new(new Guid("4D2E3F5A-6B7C-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 4, Content = "Albert Einstein" }
                    }
                },
                new(new Guid("0A1B2C3D-4E5F-6C7D-8E9F-A0B1C2D3E4F5")) {
                    DisplayOrder = 5,
                    Content = "What is the smallest unit of matter?",
                    CorrectOptionId = new Guid("4E2F3A5B-6C7D-4C7D-8E9F-A0B1C2D3E4F5"),
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("F1E2D3C4-A5B6-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 1, Content = "Quark" },
                        new(new Guid("2E3F4A5B-6C7D-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 2, Content = "Cell" },
                        new(new Guid("3E2F4A5B-6C7D-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 3, Content = "Proton" },
                        new(new Guid("4E2F3A5B-6C7D-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 4, Content = "Atom" },
                        new(new Guid("5E2F3A4B-6C7D-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 5, Content = "Molecule" },
                        new(new Guid("6E2F3A4B-6C7D-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 6, Content = "Electron" },
                        new(new Guid("7E2F3A4B-6C7D-4C7D-8E9F-A0B1C2D3E4F5")) { DisplayOrder = 7, Content = "Neutron" }
                    }
                }
            }
        };
}
