const gulp = require("gulp");
const pug = require("gulp-pug");
const concat = require("gulp-concat");
const sass = require("gulp-sass")(require("sass"));
const del = require("del");
const image = require("gulp-image");

const browserSync = require("browser-sync").create();

const { src, dest } = gulp;

gulp.task("build", (done) => {
  gulp.series("clean-all", "scss", "image", "pug", "js", "reload")(done);
});

gulp.task("pug", () => src("./src/*.pug").pipe(pug()).pipe(dest("./dist")));

gulp.task("scss", () =>
  gulp
    .src(["./assets/styles/index.scss", "./partials/**/*.scss"])
    .pipe(sass({ outputStyle: "compressed" }).on("error", sass.logError))
    .pipe(concat("index.css"))
    .pipe(gulp.dest("./dist"))
);

gulp.task("js", (resolve, reject) => {
  gulp.src("./src/js/*.js").pipe(dest("./dist/js"))
  gulp.src("./assets/js/*.js").pipe(dest("./dist/js"))
  resolve();
});

gulp.task("image", function (done) {
  gulp
    .src("./assets/images/*")
    .pipe(image())
    .pipe(gulp.dest("./dist/images"))
    .on("end", done)
    .on("end", browserSync.reload);
});

gulp.task("reload", (done) => {
  browserSync.reload();
  done();
});

gulp.task("watch", () => {
  browserSync.init({
    server: {
      baseDir: "./dist",
    },
  });

  gulp.watch(
    [
      "partials/*.scss",
      "partials/**/*.scss",
      "partials/**/*.html",
      "partials/**/*.pug",
      "src/js/*.js",
      "assets/js/*.js",
      "src/*.pug",
      "assets/styles/*.scss",
    ],
    gulp.series(["clean", "scss", "pug", "js", "reload"])
  );

  gulp.watch(
    "./assets/images/*",
    gulp.series(["clean-img", "image", "reload"])
  );
});

gulp.task("clean-all", () => del("dist/*"));
gulp.task("clean-img", () => del("dist/images/**"));
gulp.task("clean", () => del(["dist/*", "!dist/images/**"]));