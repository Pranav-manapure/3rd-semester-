import firebase_admin
from firebase_admin import credentials
from firebase_admin import db
from firebase_admin import credentials

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
    "23MCA1054":
        {
            "name": "Anshul Sharma",
            "major": "MCA",
            "starting_year": 2023,
            "total_attendance": 0,
            "Gender": "M",
            "year": 1,
            "last_attendance_time": "2022-12-11 00:54:34"
        },
    "23MCA1057":
        {
            "name": "Preeti Negi",
            "major": "MCA",
            "starting_year": 2023,
            "total_attendance": 0,
            "Gender": "F",
            "year": 2,
            "last_attendance_time": "2022-12-11 00:54:34"
        }
}

for key, value in data.items():
    ref.child(key).set(value)