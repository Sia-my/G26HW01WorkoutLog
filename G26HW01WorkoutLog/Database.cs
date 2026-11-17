using Microsoft.EntityFrameworkCore;

// [예제 변경] 네임스페이스: G26W09WFSnackList -> G26HW01WorkoutLog
namespace G26HW01WorkoutLog;

public class Database : DbContext {
    // [예제 변경] DbSet 타입: Snack -> Workout
    public DbSet<Workout> Tuples { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        // [예제 변경] DB 파일 이름: snacks.db -> workouts.db
        optionsBuilder.UseSqlite("Data Source=workouts.db");
    }

    // [예제 변경] 메서드 이름: AddInitSnack -> AddInitWorkout
    public void AddInitWorkout() {
        // [예제 변경] 초기 데이터: 스트레스 풀 야식 20개 -> 헬스·유산소 운동 기록 15개 (사진 URL도 운동 사진으로 교체)
        Tuples.AddRange(new Workout[] {
        new("바벨 백스쿼트", "5x5 · 80kg, 마지막 세트에서 하체가 터지는 느낌", "https://images.unsplash.com/photo-1590771998996-8589ec9b5ac6?w=400&h=400&fit=crop"),
        new("벤치프레스", "5x5 · 60kg, 보조 없이 끝까지 밀어 올려서 뿌듯", "https://images.unsplash.com/photo-1690731033723-ad718c6e585a?w=400&h=400&fit=crop"),
        new("컨벤셔널 데드리프트", "3x5 · 100kg, 허리 안 말리게 거울 보면서 자세 체크", "https://images.unsplash.com/photo-1556817411-31ae72fa3ea0?w=400&h=400&fit=crop"),
        new("풀업", "4세트 x 8회, 반동 없이 턱이 바 위로 올라감", "https://images.unsplash.com/photo-1604233098531-90b71b1b17a6?w=400&h=400&fit=crop"),
        new("바벨 로우", "4x10 · 50kg, 등 수축 느끼려고 천천히 내리기", "https://images.unsplash.com/photo-1517836357463-d25dfeac3438?w=400&h=400&fit=crop"),
        new("덤벨 숄더프레스", "4x12 · 16kg, 어깨 앞쪽까지 펌핑 제대로 됨", "https://images.unsplash.com/photo-1581009146145-b5ef050c2e1e?w=400&h=400&fit=crop"),
        new("덤벨 컬", "3x12 · 12kg, 마지막 세트는 반동 없이 버티기", "https://images.unsplash.com/photo-1598971475122-95a9004e2922?w=400&h=400&fit=crop"),
        new("오버헤드 프레스", "5x5 · 40kg, 코어에 힘 꽉 주고 수직으로 밀기", "https://images.unsplash.com/photo-1605296867304-46d5465a13f1?w=400&h=400&fit=crop"),
        new("덤벨 런지", "3x12(양쪽) · 14kg, 다음 날 계단 내려가기가 무서움", "https://images.unsplash.com/photo-1567598508481-65985588e295?w=400&h=400&fit=crop"),
        new("배틀로프", "30초 x 6라운드, 1분 만에 심박수 170 돌파", "https://images.unsplash.com/photo-1599058917212-d750089bc07e?w=400&h=400&fit=crop"),
        new("트레드밀 인터벌 러닝", "20분 · 1분 질주/1분 걷기 반복, 땀이 비 오듯", "https://images.unsplash.com/photo-1648995361141-30676a75fd27?w=400&h=400&fit=crop"),
        new("트레드밀 경사 걷기", "30분 · 경사 12 속도 5, 유튜브 보면서 버티기", "https://images.unsplash.com/photo-1637714409323-d5e6e9731252?w=400&h=400&fit=crop"),
        new("실내 사이클", "40분 · 12km, 하체 날 다음 날 회복용 유산소", "https://images.unsplash.com/photo-1520877880798-5ee004e3f11e?w=400&h=400&fit=crop"),
        new("줄넘기", "1000개, 쉬는 시간 포함 15분 만에 완료", "https://images.unsplash.com/photo-1773289336881-acf325c0edd3?w=400&h=400&fit=crop"),
        new("운동 후 스트레칭", "10분 · 햄스트링이랑 고관절 위주로 풀어주기", "https://images.unsplash.com/photo-1701826478825-8d975e7883f4?w=400&h=400&fit=crop")
        });
	    
        // 실제로 데이터베이스에 저장
        SaveChanges();
    }
}
