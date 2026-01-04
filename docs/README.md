# FallingRocks Portfolio Documentation

이 폴더에는 FallingRocks (Suberunker) 프로젝트의 포트폴리오 문서가 포함되어 있습니다.

## 📄 Files

- **FallingRocks-Portfolio.html**: 프로젝트의 상세한 포트폴리오 페이지
  - 프로젝트 개요 및 메타데이터
  - 게임플레이 설명 및 주요 특징
  - 기술적 구현 사항
  - 학습 포인트 및 성과

## 🎨 Usage

이 HTML 파일은 포트폴리오 웹사이트에 통합하여 사용할 수 있도록 구조화되어 있습니다.
파일에는 `<BodyArea>` 태그로 감싸진 섹션 콘텐츠가 포함되어 있으며, 
상위 웹사이트의 스타일시트와 레이아웃을 활용할 수 있도록 설계되었습니다.

### 필수 요구사항

포트폴리오 페이지를 웹사이트에 통합하기 전에 다음 항목을 확인하세요:

1. **JavaScript 함수**: 상위 페이지에 `playVideo(videoId)` 함수가 구현되어 있어야 합니다.
   - 이 함수는 YouTube 비디오를 재생하는 로직을 포함해야 합니다.
   - 예제 (The Doors 프로젝트 참조):
   ```javascript
   function playVideo(videoId) {
       // YouTube 비디오 재생 로직
   }
   ```

2. **CSS 스타일시트**: 다음 클래스들에 대한 스타일이 정의되어 있어야 합니다:
   - `.hero`, `.hero-container`, `.project-title`, `.project-tagline`
   - `.project-meta`, `.meta-item`, `.meta-icon`, `.meta-info`, `.meta-label`, `.meta-value`
   - `.container`, `.section-header`, `.section-title`, `.section-subtitle`
   - `.summary-content`, `.summary-text`, `.summary-highlights`, `.highlight-list`, `.highlight-icon`
   - `.video-container`, `.video-player`, `.video-placeholder`, `.play-overlay`, `.play-button`
   - `.learnings-grid`, `.learning-card`, `.learning-icon`, `.learning-title`, `.learning-text`
   - `.footer-nav`, `.footer-nav-item`

## ✏️ Customization

포트폴리오를 사용하기 전에 다음 항목을 수정하세요:

1. **게임플레이 영상**: 
   - `YOUR_VIDEO_ID`를 실제 YouTube 비디오 ID로 교체
   - 비디오 ID는 YouTube URL의 `v=` 파라미터 값입니다
   - 예: `https://www.youtube.com/watch?v=ABC123` → 비디오 ID는 `ABC123`

2. **스크린샷 및 이미지** (선택사항):
   - 필요 시 게임 스크린샷이나 GIF를 추가할 수 있습니다
   - The Doors 예제처럼 `<div class="image-row">` 섹션을 추가하여 이미지를 삽입할 수 있습니다

3. **프로젝트 설명 및 학습 포인트**:
   - 프로젝트의 실제 경험에 맞게 내용을 조정할 수 있습니다
   - 특정 기술이나 기능을 추가/제거할 수 있습니다
