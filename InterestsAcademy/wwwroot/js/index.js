document.addEventListener('DOMContentLoaded', function () {
    const stats = document.querySelectorAll('.stat-number');

    const options = {
        threshold: 0.5, // Trigger animation when 50% of the element is visible
    };

    const observer = new IntersectionObserver((entries, observer) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                animateNumber(entry.target);
                observer.unobserve(entry.target); // Stop observing after animation
            }
        });
    }, options);

    stats.forEach(stat => {
        observer.observe(stat); // Start observing each stat
    });

    function animateNumber(element) {
        const target = parseInt(element.getAttribute('data-target'));
        const duration = 2000; // Animation duration in milliseconds
        const start = 0;
        const increment = target / (duration / 16); // 16ms per frame for smooth animation

        let current = start;
        const timer = setInterval(() => {
            current += increment;
            if (current >= target) {
                clearInterval(timer);
                current = target;
            }
            element.textContent = Math.floor(current).toLocaleString(); // Format number with commas
        }, 16);
    }
});

document.addEventListener("DOMContentLoaded", function () {
    document.querySelectorAll(".timeline-item").forEach(item => {
        item.addEventListener("click", function (event) {
            event.preventDefault();
            let targetId = this.getAttribute("href").substring(1);

            if (targetId === "home") {
                window.scrollTo({
                    top: 0, // Scroll to the very top of the page
                    behavior: "smooth"
                });
            } else {
                let targetElement = document.getElementById(targetId);
                if (targetElement) {
                    window.scrollTo({
                        top: targetElement.offsetTop - 50, // Adjusted for fixed elements
                        behavior: "smooth"
                    });
                }
            }
        });
    });
});


document.addEventListener("DOMContentLoaded", function () {
    const timeline = document.querySelector(".timeline");
    const heroSection = document.getElementById("hero");

    window.addEventListener("scroll", function () {
        let heroBottom = heroSection.getBoundingClientRect().bottom;
        if (heroBottom < 0) {
            timeline.classList.add("dark-mode");
        } else {
            timeline.classList.remove("dark-mode");
        }
    });
});
document.addEventListener("DOMContentLoaded", function () {
    const sections = document.querySelectorAll("section, .directorcontainer");
    const timelineItems = document.querySelectorAll(".timeline-item");
    const timeline = document.querySelector(".timeline");

    function highlightActiveSection() {
        let scrollPosition = window.scrollY + window.innerHeight / 3;

        sections.forEach((section, index) => {
            let sectionTop = section.offsetTop;
            let sectionHeight = section.offsetHeight;

            if (scrollPosition >= sectionTop && scrollPosition < sectionTop + sectionHeight) {
                timelineItems.forEach(item => item.classList.remove("active"));
                timelineItems[index].classList.add("active");

                // Handle text color switch based on background
                if (section.id === "hero") {
                    timeline.classList.remove("dark-mode");
                } else if (section.id === "principal") {
                    timeline.classList.add("dark-mode"); // Keep it dark for white backgrounds
                } else {
                    timeline.classList.add("dark-mode");
                }
            }
        });
    }

    window.addEventListener("scroll", highlightActiveSection);
    highlightActiveSection(); // Run on page load
});