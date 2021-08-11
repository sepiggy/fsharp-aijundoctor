type Gender = { Gender: int }

type User =
    { Name: string
      Age: int
      Salary: float
      Gender: Gender }

let user =
    { Name = "sepiggy"
      Age = 100
      Salary = 0.0
      Gender = { Gender = 1 } }

let gender = user.Gender.Gender

let user2 = { user with Name = "jms" }

let user3 = { user with Name = "jms"; Age = 200 }

let user4 =
    {| Name = "sepiggy"
       Age = 300
       Salary = 999.9 |}

let user5 = {| user4 with Name = "jms" |}

let name_of_user5 = user5.Name