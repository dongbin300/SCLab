﻿namespace SCLab.Chk
{
	public class Chunk(string name, int length, byte[] data)
	{
		public string Name { get; set; } = name;
		public int Length { get; set; } = length;
		public byte[] Data { get; set; } = data;
		public string Description => Name switch
		{
			"TYPE" => "[선택]시나리오 타입",
			"VER " => "[필수]맵 파일 포맷 버전",
			"IVER" => "[선택]맵 버전",
			"IVE2" => "[선택]맵 버전",
			"VCOD" => "[필수]체크섬",
			"IOWN" => "[선택]플레이어 타입",
			"OWNR" => "[필수]플레이어 타입",
			"ERA " => "[필수]시나리오 타일셋",
			"DIM " => "[필수]맵 사이즈",
			"SIDE" => "[필수]플레이어 종족",
			"MTXM" => "[필수]맵 지형",
			"PUNI" => "[필수, 밀리제외]유닛 생산 제한",
			"UPGR" => "[필수(오리지널), 밀리제외]업그레이드 사용 제한",
			"PTEC" => "[필수(오리지널), 밀리제외]기술 사용 제한",
			"UNIT" => "[필수]맵에 설치된 유닛",
			"ISOM" => "[선택]맵 등각 지형",
			"TILE" => "[선택]맵 지형(ISOM에 의해 자동 생성됨)",
			"DD2 " => "[선택]맵 두댓",
			"THG2" => "[필수]맵 스프라이트(두댓 포함)",
			"MASK" => "[필수, 밀리제외]맵 전장의 안개",
			"STR " => "[필수]맵 스트링",
			"UPRP" => "[필수, 밀리제외]속성을 사용한 유닛 생산 트리거(CUWP) 작업 슬롯",
			"UPUS" => "[선택]속성을 사용한 유닛 생산 트리거(CUWP) 사용되는 슬롯",
			"MRGN" => "[필수, 밀리제외]맵 로케이션",
			"TRIG" => "[필수, 밀리제외]맵 트리거",
			"MBRF" => "[필수, 밀리제외]맵 미션 브리핑",
			"SPRP" => "[필수]시나리오 정보",
			"FORC" => "[필수]포스",
			"WAV " => "[선택]사운드파일 스트링 인덱스",
			"UNIS" => "[필수(오리지널), 밀리제외]유닛",
			"UPGS" => "[필수(오리지널), 밀리제외]업그레이드",
			"TECS" => "[필수(오리지널), 밀리제외]기술",
			"SWNM" => "[선택]맵 스위치 이름",
			"COLR" => "[필수(브루드워+)]플레이어 색상",
			"PUPx" => "[필수(하이브리드+), 밀리제외]업그레이드 사용 제한",
			"PTEx" => "[필수(하이브리드+), 밀리제외]기술 사용 제한",
			"UNIx" => "[필수(하이브리드+), 밀리제외]유닛",
			"UPGx" => "[필수(하이브리드+), 밀리제외]업그레이드",
			"TECx" => "[필수(하이브리드+), 밀리제외]기술",
			_ => ""
		};
	}
}