module.exports = function (grunt) {
  grunt.initConfig({
    coffee: {
      serve: {
        files: {
          'dev/scripts/sample-script.js': 'app/sample-script.coffee',
          'dev/scripts/another-sample-script.js': 'app/another-sample-script.coffee'
        }
      },
      build: {
        files: {
          'dist/scripts/sample-script.js': 'app/sample-script.coffee',
          'dist/scripts/another-sample-script.js': 'dist/another-sample-script.coffee'
        }
      }
    },
    jshint: {
      all: [
        'Gruntfile.js',
        'dev/scripts/**/*.js'
      ]
    },
    jade: {
      serve: {
        files: {
          'dev/sample-jade.html': 'app/sample-jade.jade'
        }
      },
      build: {
        files: {
          'dist/sample-jade.html': 'app/sample-jade.jade'
        }
      }
    },
    copy: {
      serve: {
        expand: true,
        src: 'app/images/*',
        dest: 'dev/images/',
        flatten: true,
        filter: 'isFile'
      },
      build: {
        expand: true,
        src: 'app/images/*',
        dest: 'dist/images/',
        flatten: true,
        filter: 'isFile'
      }
    },
    stylus: {
      serve: {
        files: {
          'dev/styles/app.css': 'app/app.styl'
        }
      },
      build: {
        files: {
          'dist/styles/app.css': 'app/app.styl'
        }
      }
    },
    csslint: {
      build: {
        src: ['dist/**/*.css'],
        quiet: true
      }
    },
    cssmin: {
      build: {
        files: [{
          expand: true,
          cwd: 'dist/styles',
          src: ['*.css', '!*.min.css'],
          dest: 'dist/styles/min',
          ext: '.min.css'
        }]
      }
    },
    uglify: {
      build: {
        files: {
          'dist/scripts/min/all-scripts.min.js': ['dist/scripts/sample-script.js', 'dist/scripts/another-sample-script.js']
        }
      }
    },
    watch: {
      coffee: {
        files: ['app/**/*.coffee'],
        tasks: ['coffee'],
        options: {
          livereload: true
        }
      },
      styles: {
        files: ['app/**/*.styl'],
        tasks: ['stylus'],
        options: {
          livereload: true
        }
      },
      jade: {
        files: ['app/**/*.jade'],
        tasks: ['jade'],
        options: {
          livereload: true
        }
      },
      livereload: {
        options: {
          livereload: '<%= connect.options.livereload %>'
        },
        files: [
          'app/**/*.coffee',
          'app/**/*.jade',
          'app/**/*.styl'
        ]
      }
    },
    connect: {
      options: {
        port: 9578,
        livereload: 35729,
        hostname: 'localhost'
      },
      livereload: {
        options: {
          open: true,
          base: [
            'dev'
          ]
        }
      }
    }
  });

  require('load-grunt-tasks')(grunt);

  grunt.registerTask('serve', ['coffee:serve', 'jshint', 'jade:serve', 'stylus:serve', 'copy:serve', 'connect', 'watch']);
  grunt.registerTask('build', ['coffee:build', 'stylus:build', 'csslint', 'cssmin:build', 'jshint', 'copy:build', 'jade:build', 'uglify:build']);
};