import firebase_admin # type: ignore
from firebase_admin import credentials # type: ignore
from firebase_admin import db # type: ignore
from firebase_admin import credentials # type: ignore

cred = credentials.Certificate("serviceAccountKey.json")
firebase_admin.initialize_app(cred, {
    'databaseURL': "https://attendancemanagementcc-default-rtdb.firebaseio.com/"
})

ref = db.reference('Students')

data = {
    "23MCA1041":
        {
            "name": "Pranav Sanjay Manapure",
            "major": "MCA",
            "starting_year": 2023,
            "total_attendance": 0,
            "Gender": "M",
            "year": 1,
            "last_attendance_time": "2022-12-11 00:54:34"
        },
    "VITCC52288":
        {
            "name": "Dr. Renjith PN",
            "major": "SCOPE",
            "starting_year": 2020,
            "total_attendance": 0,
            "Gender": "M",
            "year": 1,
            "last_attendance_time": "2022-12-11 00:54:34"
        },
    "VITCC53009":
        {
            "name": "Dr.G.Manju",
            "major": "SCOPE",
            "starting_year": 2020,
            "total_attendance": 0,
            "Gender": "F",
            "year": 1,
            "last_attendance_time": "2022-12-11 00:54:34"
        },
    "VITCC53161":
        {
            "name": "Dr.N. Prem Sankar",
            "major": "SCOPE",
            "starting_year": 2020,
            "total_attendance": 0,
            "Gender": "M",
            "year": 1,
            "last_attendance_time": "2022-12-11 00:54:34"
        }
}

for key, value in data.items():
    ref.child(key).set(value)