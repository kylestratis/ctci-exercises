#!/usr/bin/perl

use strict;
use warnings;
use boolean;

# Implement an algorithm to determine if string has all unique chars
# Inputs: str
sub question01 {
    my %args = @_;

    foreach my $arg (qw{str}) {
        if (!exists $args{$arg}) {
            return "Error!";
        }
    }

    my @char_array = split //, $args{str};
    my %found;
    return 0 if (scalar @char_array > 256); # Assume ASCII
    
    # Use hash here because tmk there's no equivalent 
    # charAt method to return codepoints for a character
    foreach my $char (@char_array) {
        $found{$char} += 1;
        if ($found{$char} > 1) {
            return 0;
        }
    }
    
    return 1;
}

# Inputs: str1, str2
sub question03 {
    my %args = @_;
    
    foreach my $arg (qw{str1 str2}) {
        if (!exists $args{$arg}) {
            return "Error!";
        }
    }

    my @str1_array = split //, $args{str1};
    my @str2_array = split //, $args{str2};

    return boolean::false if (scalar @str1_array != scalar @str2_array);

    my $size = scalar @str1_array;
    
    @str1_array = sort(@str1_array);
    @str2_array = sort(@str2_array);
    for (my $i = 0; $i < scalar @str1_array; $i++) { 
        return boolean::false if ($str1_array[$i] ne $str2_array[$i]);
    }
    return boolean::true;
}

# Inputs: str
sub question04 {
    my %args = @_;
    
    foreach my $arg (qw{str}) {
        if (!exists $args{$arg}) {
            return "Error!";
        }
    }

    $args{str} =~ s/\s/%20/g; # This is why Perl is superior for text manipulation
    return $args{str};
}

# Driver
my $result;
$result = question01(str => "test");
if ($result && $result ne "Error!") {
    print "Q1a Unique (incorrect)\n";
}
else {
    print "Q1a not unique (correct)\n";
}

$result = question01(str => "this");
if ($result && $result ne "Error!") {
    print "Q1b Unique (correct)\n";
}
else {
    print "Q1b not unique (incorrect)\n";
}

$result = question03(str1 => "fast", str2 => "tsaf");
print "Question 3:\n";
print "$result. Should be true\n";
$result = question03(str1 => "test", str2 => "reddit");
print "$result. Should be false\n";
$result = question03(str1 => "tests", str2 => "setss");
print "$result. Should be false\n";

$result = question04(str => "This is John Woods");
print "Question 4:\n";
print "$result\n";
$result = question04(str => "This   is John Woods");
print "$result\n";
